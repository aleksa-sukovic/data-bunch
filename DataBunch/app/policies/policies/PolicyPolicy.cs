using DataBunch.app.policies.handlers;
using DataBunch.app.policies.models;
using DataBunch.app.user.models;

namespace DataBunch.app.policies.policies
{
    public class PolicyPolicy: PolicyHandler<Policy>
    {
        protected override bool before(User user, long targetId)
        {
            return true;
        }
    }
}
