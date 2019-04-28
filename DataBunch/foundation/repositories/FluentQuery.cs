using System.Collections.Generic;
using DataBunch.foundation.db;
using DataBunch.foundation.db.facades;
using DataBunch.foundation.exceptions;
using DataBunch.foundation.models;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.repositories
{
    public class FluentQuery<T> where T: Model
    {
        private readonly DbParams query;
        private readonly string tableName;
        private readonly Transformer<T> transformer;
        private readonly BaseRepository<T> repository;
        private bool includes;

        public FluentQuery(string tableName, Transformer<T> transformer, BaseRepository<T> repository)
        {
            this.tableName = tableName;
            this.transformer = transformer;
            this.repository = repository;
            this.query = new DbParams();
            this.includes = false;
        }

        public FluentQuery<T> where(string column, string opr, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), opr, "AND"));

            return this;
        }

        public FluentQuery<T> orWhere(string column, string opr, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), opr, "OR"));

            return this;
        }

        public FluentQuery<T> whereLike(string column, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), "LIKE", "AND"));

            return this;
        }

        public FluentQuery<T> orWhereLike(string column, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), "LIKE", "OR"));

            return this;
        }

        public FluentQuery<T> withIncludes()
        {
            this.includes = true;

            return this;
        }

        public List<T> get()
        {
            var reader = DB.all(this.tableName, this.query);
            var result = new List<T>();

            while (reader.Read()) {
                var transformed = this.transformer.transform(reader);

                transformed = this.includes ? this.repository.addIncludes(transformed) : transformed;

                result.Add(this.repository.addIncludes(transformed));
            }

            reader.Close();
            return result;
        }

        public T first(bool throwException = true)
        {
            var reader = DB.all(this.tableName, this.query);

            if (!reader.HasRows && throwException) {
                throw new ItemNotFoundException();
            }

            if (!reader.HasRows) {
                return null;
            }

            reader.Read();
            var transformed = this.transformer.transform(reader);
            reader.Close();

            Log.debug(this.includes ? repository.addIncludes(transformed).ToString() : transformed.ToString());
            return this.includes ? this.repository.addIncludes(transformed) : transformed;
        }
    }
}
