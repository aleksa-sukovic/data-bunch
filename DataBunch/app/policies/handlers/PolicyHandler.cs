using DataBunch.app.foundation.exceptions;
using DataBunch.app.policies.repositories;
using DataBunch.app.user.models;
using DataBunch.foundation.models;

namespace DataBunch.app.policies.handlers
{
    public abstract class PolicyHandler<T> where T: Model
    {
        private readonly PolicyRepository policyRepository;
        protected string type;

        protected PolicyHandler()
        {
            this.policyRepository = new PolicyRepository();
        }

        public bool check(User user, T target, bool throwException = true)
        {
            if (before(user, target)) {
                return true;
            }

            var found = this.policyRepository.query()
                .where("user_id", "=", user.ID)
                .where("target_id", "=", target.ID)
                .where("type", "=", type)
                .first(false);

            if (found == null && throwException) {
                throw new UnauthorizedException();
            }

            return found != null;
        }

        protected virtual bool before(User user, T target)
        {
            return false;
        }
    }
}
