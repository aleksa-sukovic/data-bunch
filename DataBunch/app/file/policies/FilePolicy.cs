using DataBunch.app.file.models;
using DataBunch.app.policies.handlers;
using DataBunch.app.user.models;

namespace DataBunch.app.file.policies
{
    public class FilePolicy: PolicyHandler<File>
    {
        public FilePolicy()
        {
            this.type = "file";
        }

        protected override bool before(User user, long targetId)
        {
            return true;
        }
    }
}
