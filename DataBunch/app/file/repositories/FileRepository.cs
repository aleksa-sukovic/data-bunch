using System;
using System.Collections.Generic;
using DataBunch.app.collection.repositories;
using DataBunch.app.file.models;
using DataBunch.app.file.policies;
using DataBunch.app.file.transformers;
using DataBunch.app.foundation.repositories;
using DataBunch.app.foundation.utils;
using DataBunch.app.user.models;

namespace DataBunch.app.file.repositories
{
    public class FileRepository: BaseRepository<File>
    {
        private CollectionRepository collectionRepository;

        public FileRepository()
        {
            this.tableName = "files";
            this.transformer = new FileTransformer();
            this.policy = new FilePolicy();
        }

        public override File addIncludes(File model)
        {
            collectionRepository = new CollectionRepository();

            model.Collection = collectionRepository.query().where("id", "=", model.CollectionID).first(false);

            return model;
        }

        protected override void beforeSave(File item)
        {
            if (string.IsNullOrEmpty(item.Type)) {
                item.Type = getFileType(item);
            }
        }

        protected override void afterDelete(File model)
        {
            Storage.deleteFile(model.Path);
        }

        public string getFileType(File file)
        {
            if (string.IsNullOrEmpty(file.Path)) {
                return "";
            }

            return file.Path.Substring(file.Path.LastIndexOf(".", StringComparison.Ordinal) + 1);
        }

        public List<File> forUser(User user)
        {
            var availableCollections = new CollectionRepository().query().forUser(user).get();
            var query = this.query();

            foreach (var collection in availableCollections) {
                query.orWhere("collection_id", "=", collection.ID);
            }

            return query.get();
        }
    }
}
