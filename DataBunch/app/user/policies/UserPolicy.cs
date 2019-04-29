using DataBunch.app.policies.handlers;
using DataBunch.app.user.models;

namespace DataBunch.app.user.policies
{
    public class UserPolicy: PolicyHandler<User>
    {
        public UserPolicy()
        {
            this.type = "user";
        }

        protected override bool before(User user, long targetId)
        {
            return user != null && (user.isAdmin() || user.ID == targetId);
        }
    }
}
