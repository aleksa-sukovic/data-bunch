using System;
using DataBunch.app.foundation.repositories;
using DataBunch.app.sessions.models;
using DataBunch.app.sessions.policies;
using DataBunch.app.sessions.transformers;
using DataBunch.app.user.repositories;

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
            this.policy = new SessionPolicy();
        }

        public override Session addIncludes(Session model)
        {
            model.User = userRepository.query().where("id", "=", model.UserID).first(false);

            return model;
        }

        public Session getActiveSession()
        {
            return query().where("active", "=", 1).withIncludes().first(false);
        }
    }
}
