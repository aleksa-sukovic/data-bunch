using DataBunch.app.sessions.models;
using DataBunch.app.sessions.transformers;
using DataBunch.foundation.repositories;

namespace DataBunch.app.sessions.repositories
{
    public class SessionRepository: BaseRepository<Session>
    {
        public SessionRepository()
        {
            this.tableName = "sessions";
            this.transformer = new SessionTransformer();
        }
    }
}
