using DataBunch.app.foundation.repositories;
using DataBunch.collection.repositories;
using DataBunch.file.models;
using DataBunch.file.transformers;
using DataBunch.foundation.repositories;

namespace DataBunch.file.repositories
{
    public class FileRepository: BaseRepository<File>
    {
        private CollectionRepository collectionRepository;

        public FileRepository()
        {
            this.tableName = "files";
            this.transformer = new FileTransformer();
        }

        public override File addIncludes(File model)
        {
            this.collectionRepository = new CollectionRepository();

            model.Collection = this.collectionRepository.query().where("id", "=", model.CollectionID).first(false);

            return model;
        }
    }
}
