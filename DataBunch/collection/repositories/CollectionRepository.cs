using System;
using DataBunch.collection.models;
using DataBunch.collection.transformers;
using DataBunch.file.repositories;
using DataBunch.foundation.models;
using DataBunch.foundation.repositories;
using DataBunch.user.repositories;

namespace DataBunch.collection.repositories
{
    public class CollectionRepository: BaseRepository<Collection>
    {
        private readonly FileRepository fileRepository;
        private readonly UserRepository userRepository;

        public CollectionRepository()
        {
            this.tableName = "collections";
            this.transformer = new CollectionTransformer();
            this.fileRepository = new FileRepository();
            this.userRepository = new UserRepository();
        }

        public override Collection addIncludes(Collection model)
        {
            Console.WriteLine("Add Includes Collection");
            model.Files = this.fileRepository.query().where("collection_id", "=", model.ID).get();
            model.User = this.userRepository.query().where("id", "=", model.UserID).first(false);
            model.Parent = this.query().where("id", "=", model.ParentID).first(false);
            model.Children = this.query().where("parent_id", "=", model.ID).get();

            return model;
        }

        protected override void afterSave(Collection beforeSave, Collection afterSave)
        {
            saveFiles(beforeSave, afterSave);
            saveChildren(beforeSave, afterSave);
        }

        private void saveFiles(Collection beforeSave, Collection afterSave)
        {
            beforeSave.Files.ForEach(file => { file.CollectionID = afterSave.ID; });
            this.fileRepository.saveMany(beforeSave.Files);
        }

        private void saveChildren(Collection beforeSave, Collection afterSave)
        {
            if (beforeSave.Children == null) {
                return;
            }

            beforeSave.Children.ForEach(child => child.ParentID = afterSave.ID);
            this.saveMany(beforeSave.Children);
        }
    }
}
