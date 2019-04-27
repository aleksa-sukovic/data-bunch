using DataBunch.foundation.repositories;
using DataBunch.user.models;
using DataBunch.user.transformers;

namespace DataBunch.user.repositories
{
    public class UserRepository: BaseRepository<User>
    {
        public UserRepository()
        {
            this.tableName = "users";
            this.transformer = new UserTransformer();
        }
    }
}
