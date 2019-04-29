using DataBunch.app.policies.handlers;
using DataBunch.app.user.models;
using DataBunch.file.models;

namespace DataBunch.app.file.policies
{
    public class FilePolicy: PolicyHandler<File>
    {
        protected override bool before(User user, long targetId)
        {
            return true;
        }
    }
}
