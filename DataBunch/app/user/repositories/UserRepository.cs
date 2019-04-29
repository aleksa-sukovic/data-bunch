using System.Collections.Generic;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.user.models;
using DataBunch.app.user.transformers;
using DataBunch.collection.repositories;
using DataBunch.foundation.db;
using DataBunch.foundation.repositories;

namespace DataBunch.app.user.repositories
{
    public class UserRepository: BaseRepository<User>
    {
        private CollectionRepository collectionRepository;

        public UserRepository()
        {
            this.tableName = "users";
            this.transformer = new UserTransformer();
        }

        public User findByUsername(string username)
        {
            return query().where("username", "=", username).first();
        }

        protected override void beforeSave(User item)
        {
            var existingUsername = query().where("username", "=", item.Username).first(false);

            if (existingUsername != null) {
                throw new ValidationException("User with username '" + item.Username + "' already exists!");
            }
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
