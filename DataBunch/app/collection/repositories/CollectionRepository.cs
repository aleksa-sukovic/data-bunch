using System;
using System.Collections.Generic;
using System.IO;
using DataBunch.app.collection.factories;
using DataBunch.app.collection.models;
using DataBunch.app.collection.policies;
using DataBunch.app.collection.transformers;
using DataBunch.app.file.repositories;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.foundation.repositories;
using DataBunch.app.foundation.utils;
using DataBunch.app.user.repositories;

namespace DataBunch.app.collection.repositories
{
    public class CollectionRepository: BaseRepository<Collection>
    {
        private readonly FileRepository fileRepository;
        private readonly UserRepository userRepository;

        public CollectionRepository()
        {
            tableName = "collections";
            transformer = new CollectionTransformer();
            policy = new CollectionPolicy();
            fileRepository = new FileRepository();
            userRepository = new UserRepository();
        }

        public override Collection addIncludes(Collection model)
        {
            model.Files = fileRepository.query().where("collection_id", "=", model.ID).get();
            model.User = userRepository.query().where("id", "=", model.UserID).first(false);
            model.Parent = query().where("id", "=", model.ParentID).first(false);
            model.Children = query().where("parent_id", "=", model.ID).get();

            return model;
        }

        protected override void beforeSave(Collection item)
        {
            item = addIncludes(item);

            if (string.IsNullOrEmpty(item.Type) && item.Files.Count > 0) {
                item.Type = item.Files[0].Type;
            }

            if (item.ParentID != 0 && !item.isNull()) {
                checkParentId(item, item.ParentID);
                updateCollectionPaths(item, item.ParentID);
            }
        }

        protected override void afterSave(Collection beforeSave, Collection afterSave)
        {
            saveFiles(beforeSave, afterSave);
            saveChildren(beforeSave, afterSave);
        }

        private void saveFiles(Collection beforeSave, Collection afterSave)
        {
            beforeSave.Files.ForEach(file => {
                file.CollectionID = afterSave.ID;

                if (file.Type != afterSave.Type) {
                    throw new ValidationException("You can not have file of different type in same collection.");
                }
            });

            fileRepository.saveMany(beforeSave.Files);
        }

        private void saveChildren(Collection beforeSave, Collection afterSave)
        {
            beforeSave.Children.ForEach(child => child.ParentID = afterSave.ID);

            saveMany(beforeSave.Children);
        }

        protected override void afterDelete(Collection model)
        {
            Storage.deleteDirectory(model.Path);

            var files = fileRepository.query().where("collection_id", "=", model.ID).get();

            foreach (var file in files) {
                fileRepository.delete(file);
            }
        }

        public Collection createFromDirectory(string path, string name, long parentId = 0)
        {
            var collection = CollectionFactory.createFromDirectory(path, name);

            collection.ParentID = 0;

            return save(collection);
        }

        public Collection createFromZip(string path, string name, long parentId = 0)
        {
            var collection = CollectionFactory.createFromZip(path, name);

            collection.ParentID = parentId;

            return save(collection);
        }

        public void exportToZip(Collection collection, string destination, string archiveName)
        {
            CollectionFactory.exportToZip(collection, destination, archiveName);
        }

        public Collection merge(Collection first, Collection second, string name)
        {
            var collection = save(CollectionFactory.merge(first, second, name));

            mergeCleanup();

            return collection;
        }

        private void mergeCleanup()
        {
            var allCollections = all(new List<QueryParam>());

            foreach (var collection in allCollections) {
                if (!Directory.Exists(collection.Path)) {
                    delete(collection);
                }

                foreach (var file in collection.Files) {
                    if (!File.Exists(file.Path)) {
                        fileRepository.delete(file);
                    }
                }
            }
        }

        private void updateCollectionPaths(Collection item, long parentId)
        {
            var newParent = one(parentId);

            // update path
            var oldPath = item.Path;
            var newPath = newParent.Path + "/" + item.Name;
            Storage.copyDirectory(oldPath, newPath);
            Storage.deleteDirectory(oldPath);
            item.Path = newPath;

            // update file path
            foreach (var file in item.Files) {
                file.Path = file.Path.Replace(oldPath, newPath);
            }
        }

        private void checkParentId(Collection item, long parentId)
        {
            var children = query().where("parent_id", "=", item.ID).withIncludes().get();

            foreach (var child in children) {
                if (child.ID == parentId) {
                    throw new ValidationException("You can not set child collection as parent.");
                }

                checkParentId(child, parentId);
            }
        }
    }
}
