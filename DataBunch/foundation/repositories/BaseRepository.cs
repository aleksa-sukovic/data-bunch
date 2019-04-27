using System.Data;
using DataBunch.foundation.db;
using DataBunch.foundation.exceptions;
using DataBunch.foundation.facades;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.repositories
{
    public abstract class BaseRepository<Model> where Model: class
    {
        protected string tableName = "";
        protected Transformer<Model> transformer;

        public Model[] read()
        {
            return null;
        }

        public Model one(int id)
        {
            var reader = DB.all(this.tableName, new DbParams(new DbParam[] {
                new DbParam("id", id, SqlDbType.Int, "="),
            }));

            if (!reader.HasRows) {
                throw new ItemNotFoundException();
            }

            reader.Read();
            return transformer.transform(reader);
        }

        public Model save(Model model)
        {
            return null;
        }

        public Model create(Model model)
        {
            return null;
        }

        public Model update(Model model)
        {
            return null;
        }

        public Model[] delete(Model model)
        {
            return null;
        }
    }
}
