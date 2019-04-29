using System;
using DataBunch.foundation.models;
using DataBunch.user.models;

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
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Session(long id, long userId, string action, DateTime createdAt, DateTime updatedAt): base(id)
        {
            UserID = userId;
            Action = action;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Session(long userId, string action)
        {
            UserID = userId;
            Action = action;
        }

        public long UserID { get; set; }
        public string Action { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
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
    }
}