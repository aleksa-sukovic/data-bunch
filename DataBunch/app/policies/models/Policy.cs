using System;
using DataBunch.foundation.models;

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

        public Policy(int id, int userId, int targetId, string type, DateTime createdAt, DateTime updatedAt): base(id)
        {
            this.UserID = userId;
            this.TargetID = targetId;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public Policy(int userId, int targetId, string type)
        {
            this.UserID = userId;
            this.TargetID = targetId;
            this.Type = type;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public int UserID { get; set; }
        public int TargetID { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public override string ToString()
        {
            return "{ ID => " + ID + ", UserID => " + UserID + ", TargetID => " + TargetID + ", Type => " + Type + " }";
        }
    }
}
