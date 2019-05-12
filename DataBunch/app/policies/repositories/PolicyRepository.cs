using DataBunch.app.collection.models;
using DataBunch.app.collection.repositories;
using DataBunch.app.foundation.repositories;
using DataBunch.app.policies.models;
using DataBunch.app.policies.policies;
using DataBunch.app.policies.transformers;
using DataBunch.app.user.models;
using DataBunch.app.user.repositories;

namespace DataBunch.app.policies.repositories
{
    public class PolicyRepository: BaseRepository<Policy>
    {
        public PolicyRepository()
        {
            this.tableName = "policies";
            this.transformer = new PolicyTransformer();
            this.policy = new PolicyPolicy();
        }

        public void grantToCollection(Collection collection, User user)
        {
            var existing = query().where("user_id", "=", user.ID)
                .where("target_id", "=", collection.ID)
                .where("type", "=", "collection")
                .first(false);

            if (existing == null) {
                create(new Policy(user.ID, collection.ID, "collection"));
            }

            collection = new CollectionRepository().addIncludes(collection);

            foreach (var child in collection.Children) {
                grantToCollection(child, user);
            }
        }

        public void revokeFromCollection(Collection collection, User user)
        {
            var existing = query().where("user_id", "=", user.ID)
                .where("target_id", "=", collection.ID)
                .where("type", "=", "collection")
                .first(false);

            if (existing != null) {
                delete(existing);
            }

            collection = new CollectionRepository().addIncludes(collection);

            foreach (var child in collection.Children) {
                revokeFromCollection(child, user);
            }
        }

        public override Policy addIncludes(Policy model)
        {
            model.User = new UserRepository().query().where("id", "=", model.UserID).first();
            model.Collection = new CollectionRepository().query().where("id", "=", model.TargetID).first();

            return model;
        }
    }
}
