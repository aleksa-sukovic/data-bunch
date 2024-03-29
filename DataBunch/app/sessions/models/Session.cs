using System;
using DataBunch.app.foundation.models;
using DataBunch.app.user.models;

namespace DataBunch.app.sessions.models
{
    public class Session: Model
    {
        private User user;

        public Session()
        {
            UserID = -1;
            user = null;
            Action = "";
            Active = false;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Session(long id, long userId, string action, bool active, DateTime createdAt, DateTime updatedAt): base(id)
        {
            UserID = userId;
            Action = action;
            Active = active;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Session(long userId, string action, bool active)
        {
            UserID = userId;
            Action = action;
            Active = active;
        }

        public Session(Session session)
        {
            ID = session.ID;
            UserID = session.UserID;
            User = session.User;
            Action = session.Action;
            Active = session.Active;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public long UserID { get; set; }
        public string Action { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Active { get; set; }
        public User User
        {
            get => this.user;
            set {
                if (value != null) {
                    UserID = value.ID;
                }

                user = value;
            }
        }

        public override string ToString()
        {
            return "{ ID => " + ID + ", UserID => " + UserID + ", Action => " + Action + ", Active => " + Active + " }";
        }
    }
}
