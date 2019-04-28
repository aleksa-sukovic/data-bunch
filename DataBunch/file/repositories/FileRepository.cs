using DataBunch.file.models;
using DataBunch.file.transformers;
using DataBunch.foundation.repositories;

namespace DataBunch.file.repositories
{
    public class FileRepository: BaseRepository<File>
    {
        public FileRepository()
        {
            this.tableName = "files";
            this.transformer = new FileTransformer();
        }
    }
}
