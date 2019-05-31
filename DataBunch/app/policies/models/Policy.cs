using System;
using DataBunch.app.collection.models;
using DataBunch.app.foundation.models;
using DataBunch.app.user.models;

namespace DataBunch.app.policies.models
{
    public class Policy: Model
    {
        public Policy()
        {
            this.UserID = -1;
            this.TargetID = -1;
            this.Type = "user";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public Policy(int id, long userId, long targetId, string type, DateTime createdAt, DateTime updatedAt): base(id)
        {
            this.UserID = userId;
            this.TargetID = targetId;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public Policy(long userId, long targetId, string type)
        {
            this.UserID = userId;
            this.TargetID = targetId;
            this.Type = type;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public long UserID { get; set; }
        public long TargetID { get; set; }
        public string Type { get; set; }
        public User User { get; set; }
        public Collection Collection { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public override string ToString()
        {
            return "{ ID => " + ID + ", UserID => " + UserID + ", TargetID => " + TargetID + ", Type => " + Type + " }";
        }

        public override string[] ToArray()
        {
            return new string[] { User?.Name ?? UserID.ToString(), Collection?.Name ?? TargetID.ToString(), Type };
        }
    }
}
