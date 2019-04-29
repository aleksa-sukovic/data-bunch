using DataBunch.app.collection.repositories;
using DataBunch.app.file.models;
using DataBunch.app.file.transformers;
using DataBunch.app.foundation.repositories;

namespace DataBunch.app.file.repositories
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
