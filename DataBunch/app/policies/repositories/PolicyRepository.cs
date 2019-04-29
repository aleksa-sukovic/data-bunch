using DataBunch.app.foundation.repositories;
using DataBunch.app.policies.models;
using DataBunch.app.policies.policies;
using DataBunch.app.policies.transformers;

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
    }
}
