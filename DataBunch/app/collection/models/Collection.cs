using System;
using System.Collections.Generic;
using DataBunch.app.file.models;
using DataBunch.app.foundation.models;
using DataBunch.app.user.models;

namespace DataBunch.app.collection.models
{
    public class Collection: Model
    {
        private string name;
        private string type;
        private int size;
        private List<File> files;
        private List<Collection> children;
        private long userId;
        private User user;
        private long parentId;
        private Collection parent;
        private DateTime createdAt;
        private DateTime updatedAt;

        public Collection()
        {
            this.name = "";
            this.userId = -1;
            this.user = null;
            this.parentId = -1;
            this.parent = null;
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
            this.type = "txt";
            this.size = 0;
            files = new List<File>();
            children = new List<Collection>();
        }

        public Collection(long id, string name, long userId, long parentId, string type, DateTime createdAt, DateTime updatedAt,
            int size = 0, User user = null, Collection parent = null): base(id)
        {
            this.name = name;
            this.parentId = parentId;
            this.type = type;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.size = size;
            this.user = user;
            this.userId = user?.ID ?? userId;
            this.parent = parent;
            files = new List<File>();
            children = new List<Collection>();
        }

        public Collection(string name, long userId, long parentId, string type, int size = 0, User user = null, Collection parent = null)
        {
            this.name = name;
            this.ParentID = parentId;
            this.type = type;
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
            this.size = size;
            this.user = user;
            this.userId = user?.ID ?? userId;
            this.parent = parent;
            files = new List<File>();
            children = new List<Collection>();
        }

        public void addFile(File file)
        {
            this.Files.Add(file);
            this.Size = this.Files.Count;
        }

        public void removeFile(File file)
        {
            this.Files.Remove(file);
            this.Size = this.Files.Count;
        }

        public string Name { get => this.name; set => this.name = value; }
        public long ParentID { get => this.parentId; set => this.parentId = value; }
        public long UserID { get => this.userId; set => this.UserID = userId; }
        public DateTime CreatedAt { get => this.createdAt; set => this.createdAt = value; }
        public DateTime UpdatedAt { get => this.updatedAt; set => this.updatedAt = value; }
        public string Type { get => this.type; set => this.type = value; }
        public int Size { get => this.size; set => this.size = value; }
        public List<Collection> Children { get => this.children; set => this.children = value; }

        public User User
        {
            get => this.user;
            set {
                if (value != null) {
                    this.userId = value.ID;
                }

                this.user = value;
            }
        }

        public Collection Parent
        {
            get => this.parent;
            set {
                if (value != null) {
                    this.parentId = value.ID;
                }

                this.parent = value;
            }
        }

        public List<File> Files
        {
            get => this.files;
            set {
                this.files = value;
                this.Size = value?.Count ?? 0;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }

            return obj is Collection collection && collection.ID == ID;
        }

        public override int GetHashCode()
        {
            return (int) ID;
        }

        public override string ToString()
        {
            var output = "{ Name => " + Name + " Type => " + Type + " Size => " + Size + " Files => [";

            foreach (var file in Files) {
                output += "{ " + file.Name + " }, ";
            }

            return output.Substring(0, output.Length - 2) + "]";
        }
    }
}
