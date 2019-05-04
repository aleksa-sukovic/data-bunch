using System;
using System.Collections.Generic;
using DataBunch.app.file.models;
using DataBunch.app.foundation.models;
using DataBunch.app.user.models;

namespace DataBunch.app.collection.models
{
    public class Collection: Model
    {
        private List<File> files;
        private List<Collection> children;
        private User user;
        private Collection parent;

        public Collection()
        {
            Name = "";
            Path = "";
            UserID = -1;
            ParentID = -1;
            parent = null;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Type = "txt";
            Size = 0;
            files = new List<File>();
            children = new List<Collection>();
        }

        public Collection(long id, string name, string path, long userId, long parentId, string type, DateTime createdAt, DateTime updatedAt,
            int size = 0, User user = null, Collection parent = null): base(id)
        {
            Name = name;
            Path = path;
            ParentID = parentId;
            Type = type;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Size = size;
            this.user = user;
            this.parent = parent;
            UserID = user?.ID ?? userId;
            files = new List<File>();
            children = new List<Collection>();
        }

        public Collection(string name, string path, long userId, long parentId, string type = "no-files", int size = 0, User user = null, Collection parent = null)
        {
            Name = name;
            Path = path;
            ParentID = parentId;
            Type = type;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Size = size;
            this.user = user;
            UserID = user?.ID ?? userId;
            this.parent = parent;
            files = new List<File>();
            children = new List<Collection>();
        }

        public void addFile(File file)
        {
            Files.Add(file);
            Size = Files.Count;
            Type = Size != 0 ? Files.ToArray()[0].Type : "no-files";
        }

        public void removeFile(File file)
        {
            Files.Remove(file);
            Size = Files.Count;
            Type = Size != 0 ? Files.ToArray()[0].Type : "no-files";
        }

        public string Name { get; set; }
        public long ParentID { get; set; }
        public long UserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public string Path { get; set; }
        public List<Collection> Children { get => children; set => children = value; }

        public User User
        {
            get => user;
            set {
                if (value != null) {
                    UserID = value.ID;
                }

                user = value;
            }
        }

        public Collection Parent
        {
            get => parent;
            set {
                if (value != null) {
                    ParentID = value.ID;
                }

                parent = value;
            }
        }

        public List<File> Files
        {
            get => this.files;
            set {
                files = value;
                Size = value?.Count ?? 0;
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
            var output = "{ Name => " + Name + " Type => " + Type + " Size => " + Size + " Path => " + Path + " Files => [";

            foreach (var file in Files) {
                output += "{ " + file.Name + " }, ";
            }

            return output.Substring(0, output.Length - 2) + "}";
        }

        public string[] ToArray()
        {
            return new string[]
            {
                Name, Type, User?.Name ?? UserID.ToString(), Path
            };
        }
    }
}
