using System;
using DataBunch.app.collection.models;
using DataBunch.app.foundation.models;

namespace DataBunch.app.file.models
{
    public class File: Model
    {
        private string path;
        private string name;
        private string type;
        private long collectionId;
        private Collection collection;
        private DateTime createdAt;
        private DateTime updatedAt;

        public File()
        {
            this.path = "";
            this.name = "";
            this.type = "";
            this.collectionId = -1;
            this.collection = null;
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
        }

        public File(long id, string path, string name, string type, long collectionId, DateTime createdAt, DateTime updatedAt,
            Collection collection = null): base(id)
        {
            this.path = path;
            this.name = name;
            this.type = type;
            this.collectionId = collectionId;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.collection = collection;
        }

        public File(string path, string name, string type, long collectionId = 0,
            Collection collection = null)
        {
            this.path = path;
            this.name = name;
            this.type = type;
            this.collectionId = collectionId;
            this.createdAt = DateTime.Now;
            this.updatedAt = DateTime.Now;
            this.collection = collection;
        }

        public string Path { get => this.path; set => this.path = value; }
        public string Name { get => this.name; set => this.name = value; }
        public string Type { get => this.type; set => this.type = value; }
        public long CollectionID { get => this.collectionId; set => this.collectionId = value; }
        public DateTime CreatedAt { get => this.createdAt; set => this.createdAt = value; }
        public DateTime UpdatedAt { get => this.updatedAt; set => this.updatedAt = value; }

        public Collection Collection
        {
            get => this.collection;
            set {
                if (value != null) {
                    this.collectionId = value.ID;
                }

                this.collection = value;
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
