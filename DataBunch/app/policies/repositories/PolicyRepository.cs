using DataBunch.app.foundation.repositories;
using DataBunch.app.policies.models;
using DataBunch.app.policies.transformers;
using DataBunch.foundation.repositories;

namespace DataBunch.app.policies.repositories
{
    public class PolicyRepository: BaseRepository<Policy>
    {
        public PolicyRepository()
        {
            this.tableName = "policies";
            this.transformer = new PolicyTransformer();
        }
    }
}
