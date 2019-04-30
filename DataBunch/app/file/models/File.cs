using System;
using DataBunch.app.collection.models;
using DataBunch.app.foundation.models;

namespace DataBunch.app.file.models
{
    public class File: Model
    {
        private Collection collection;

        public File()
        {
            Path = "";
            Name = "";
            Type = "";
            CollectionID = -1;
            collection = null;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public File(long id, string path, string name, string type, long collectionId, DateTime createdAt, DateTime updatedAt,
            Collection collection = null): base(id)
        {
            Path = path;
            Name = name;
            Type = type;
            CollectionID = collectionId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            this.collection = collection;
        }

        public File(string path, string name, string type, long collectionId = 0,
            Collection collection = null)
        {
            Path = path;
            Name = name;
            Type = type;
            CollectionID = collectionId;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            this.collection = collection;
        }

        public string Path { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public long CollectionID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Collection Collection
        {
            get => this.collection;
            set {
                if (value != null) {
                    CollectionID = value.ID;
                }

                collection = value;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }

            return obj is File file && file.ID == ID;
        }

        public override int GetHashCode()
        {
            return (int) ID;
        }
    }
}
