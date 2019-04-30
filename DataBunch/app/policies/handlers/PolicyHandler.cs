using System;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.foundation.models;
using DataBunch.app.policies.repositories;
using DataBunch.app.sessions.services;
using DataBunch.app.user.models;

namespace DataBunch.app.policies.handlers
{
    public abstract class PolicyHandler<T> where T: Model
    {
        protected string type;

        public virtual bool checkCreate(Type t, User user = null, bool throwException = true)
        {
            return true;
        }

        public virtual bool checkShow(long targetId, User user = null, bool throwException = true)
        {
            return doCheck(targetId, user, throwException);
        }

        public virtual bool checkList(Type t, User user = null, bool throwException = true)
        {
            return before(parseUser(user), 0);
        }

        public virtual bool checkUpdate(long targetId, User user = null, bool throwException = true)
        {
            return doCheck(targetId, user, throwException);
        }

        public virtual bool checkDelete(long targetId, User user = null, bool throwException = true)
        {
            return doCheck(targetId, user, throwException);
        }

        protected bool doCheck(long targetId, User user, bool throwException = true)
        {
            if (before(user, targetId)) {
                return true;
            }

            var found = new PolicyRepository().query()
                .where("user_id", "=", user?.ID ?? 0)
                .where("target_id", "=", targetId)
                .where("type", "=", type)
                .first(false);

            if (found == null && throwException) {
                throw new UnauthorizedException();
            }

            return found != null;
        }

        protected virtual bool before(User user, long targetId)
        {
            return false;
        }

        protected User parseUser(User user = null, bool throwException = true)
        {
            if (user == null && !Auth.isLoggedIn() && throwException) {
                throw new UnauthorizedException("Please log in.");
            }

            return user ?? Auth.getUser();
        }
    }
}
