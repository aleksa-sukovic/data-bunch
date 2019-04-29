using System;
using DataBunch.app.collection.models;
using DataBunch.app.collection.repositories;
using DataBunch.app.policies.handlers;
using DataBunch.app.user.models;

namespace DataBunch.app.collection.policies
{
    public class CollectionPolicy: PolicyHandler<Collection>
    {
        protected override bool before(User user, long targetId)
        {
            return user != null && user.isAdmin();
        }

        public override bool checkList(Type t, User user = null, bool throwException = true)
        {
            return true;
        }

        public override bool checkCreate(Type t, User user = null, bool throwException = true)
        {
            return true;
        }

        public override bool checkUpdate(long targetId, User user = null, bool throwException = true)
        {
            user = this.parseUser(user);

            var collection = new CollectionRepository().query().where("user_id", "=", user?.ID ?? 0).first(false);

            return user != null && collection != null && user.ID == collection.UserID;
        }

        public override bool checkDelete(long targetId, User user = null, bool throwException = true)
        {
            user = this.parseUser(user);

            var collection = new CollectionRepository().query().where("user_id", "=", user?.ID ?? 0).first(false);

            return user != null && collection != null && user.ID == collection.UserID;
        }

        public override bool checkShow(long targetId, User user = null, bool throwException = true)
        {
            user = this.parseUser(user);

            var collection = new CollectionRepository().query().where("user_id", "=", user?.ID ?? 0).first(false);

            return user != null && collection != null && user.ID == collection.UserID;
        }
    }
}
