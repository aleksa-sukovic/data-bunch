using DataBunch.collection.models;
using DataBunch.collection.transformers;
using DataBunch.foundation.repositories;

namespace DataBunch.collection.repositories
{
    public class CollectionRepository: BaseRepository<Collection>
    {
        public CollectionRepository()
        {
            this.tableName = "collections";
            this.transformer = new CollectionTransformer();
        }
    }
}
