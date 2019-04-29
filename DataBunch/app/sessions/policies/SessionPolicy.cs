using DataBunch.app.policies.handlers;
using DataBunch.app.sessions.models;
using DataBunch.app.user.models;

namespace DataBunch.app.sessions.policies
{
    public class SessionPolicy: PolicyHandler<Session>
    {

        public SessionPolicy()
        {
            this.type = "session";
        }
        protected override bool before(User user, long targetId)
        {
            return true;
        }
    }
}
