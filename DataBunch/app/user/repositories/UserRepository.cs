using System.Collections.Generic;
using DataBunch.collection.repositories;
using DataBunch.foundation.db;
using DataBunch.foundation.repositories;
using DataBunch.user.models;
using DataBunch.user.transformers;

namespace DataBunch.user.repositories
{
    public class UserRepository: BaseRepository<User>
    {
        private CollectionRepository collectionRepository;

        public UserRepository()
        {
            this.tableName = "users";
            this.transformer = new UserTransformer();
        }

        public override User addIncludes(User model)
        {
            addCollections(model);

            return model;
        }

        private void addCollections(User model)
        {
            this.collectionRepository = new CollectionRepository();

            if (model.isAdmin()) {
                model.Collections = this.collectionRepository.all(new List<QueryParam>());

                return;
            }

            model.Collections = this.collectionRepository.query()
                .where("user_id", "=", model.ID)
                .orWhereExists("SELECT * FROM policies P WHERE P.collection_id = id AND P.user_id=" + model.ID)
                .get();
        }
    }
}
