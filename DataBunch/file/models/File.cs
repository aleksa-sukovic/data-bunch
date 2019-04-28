using System;
using System.Globalization;
using DataBunch.collection.models;
using DataBunch.foundation.models;

namespace DataBunch.file.models
{
    public class File: Model
    {
        public File()
        {
            this.Path = "";
            this.Name = "";
            this.Type = "";
            this.CollectionID = -1;
            this.Collection = null;
            this.CreatedAt = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            this.UpdatedAt = DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }

        public File(long id, string path, string name, string type, long collectionId, string createdAt, string updatedAt,
            Collection collection = null): base(id)
        {
            this.Path = path;
            this.Name = name;
            this.Type = type;
            this.CollectionID = collectionId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Collection = collection;
        }

        public string Path { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public long CollectionID { get; set; }

        public Collection Collection
        {
            get => this.Collection;
            set {
                if (value != null) {
                    this.CollectionID = value.ID;
                }

                this.Collection = value;
            }
        }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
