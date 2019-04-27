using System.Collections.Generic;
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
        private readonly FluentQuery<Model> fluentQuery;

        public List<Model> all(List<QueryParam> queryParams)
        {
            var dbParams = new DbParams();
            foreach (var param in queryParams) {
                dbParams.add(new DbParam(param.Name, param.Value, this.transformer.getParamType(param.Name), param.Operator, param.BooleanOpr));
            }

            var reader = DB.all(this.tableName, dbParams);
            var result = new List<Model>();

            while (reader.Read()) {
                result.Add(this.transformer.transform(reader));
            }

            return result;
        }

        public FluentQuery<Model> query()
        {
            return new FluentQuery<Model>(this.tableName, this.transformer);
        }

        public Model one(int id)
        {
            var reader = DB.all(this.tableName, new DbParams(new DbParam[] {
                new DbParam("id", id, this.transformer.getParamType("id"), "="),
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
