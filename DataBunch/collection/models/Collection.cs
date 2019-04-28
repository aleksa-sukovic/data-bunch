using System;
using System.Globalization;
using DataBunch.foundation.models;
using DataBunch.user.models;

namespace DataBunch.collection.models
{
    public class Collection: Model
    {
        public Collection()
        {
            this.Name = "";
            this.UserID = -1;
            this.User = null;
            this.ParentId = -1;
            this.Parent = null;
            this.CreatedAt = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            this.UpdatedAt = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            this.Type = "txt";
            this.Size = 0;
        }

        public Collection(long id, string name, long userId, long parentId, string type, string createdAt, string updatedAt,
            int size = 0, User user = null, Collection parent = null): base(id)
        {
            this.Name = name;
            this.UserID = userId;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Size = size;
            this.User = user;
            this.Parent = parent;
        }

        public string Name { get; set; }
        public long ParentId { get; set; }
        public Collection Parent
        {
            get => this.Parent;
            set {
                if (value != null) {
                    this.ParentId = value.ID;
                }

                this.Parent = value;
            }
        }
        public long UserID { get; set; }
        public User User
        {
            get => this.User;
            set {
                if (value != null) {
                    this.UserID = value.ID;
                }

                this.User = value;
            }
        }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
    }
}
