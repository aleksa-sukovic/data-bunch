using DataBunch.app.sessions.models;
using DataBunch.app.sessions.transformers;
using DataBunch.foundation.repositories;
using DataBunch.user.repositories;

namespace DataBunch.app.sessions.repositories
{
    public class SessionRepository: BaseRepository<Session>
    {
        private readonly UserRepository userRepository;

        public SessionRepository()
        {
            this.tableName = "sessions";
            this.transformer = new SessionTransformer();
            this.userRepository = new UserRepository();
        }

        public override Session addIncludes(Session model)
        {
            model.User = userRepository.query().where("id", "=", model.ID).first(false);

            return model;
        }
    }
}
