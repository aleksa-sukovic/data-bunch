using System;
using System.Collections.Generic;
using System.Data;
using DataBunch.foundation.db;
using DataBunch.foundation.db.facades;
using DataBunch.foundation.exceptions;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.repositories
{
    public class FluentQuery<Model>
    {
        private readonly DbParams query;
        private readonly string tableName;
        private readonly Transformer<Model> transformer;

        public FluentQuery(string tableName, Transformer<Model> transformer)
        {
            this.tableName = tableName;
            this.transformer = transformer;
            this.query = new DbParams();
        }

        public FluentQuery<Model> where(string column, string opr, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), opr, "AND"));

            return this;
        }

        public FluentQuery<Model> orWhere(string column, string opr, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), opr, "OR"));

            return this;
        }

        public FluentQuery<Model> whereLike(string column, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), "LIKE", "AND"));

            return this;
        }

        public FluentQuery<Model> orWhereLike(string column, object value)
        {
            this.query.add(new DbParam(column, value, this.transformer.getParamType(column), "LIKE", "OR"));

            return this;
        }

        public List<Model> get()
        {
            var reader = DB.all(this.tableName, this.query);
            var result = new List<Model>();

            while (reader.Read()) {
                result.Add(this.transformer.transform(reader));
            }

            reader.Close();
            return result;
        }

        public Model first()
        {
            var reader = DB.all(this.tableName, this.query);

            if (!reader.HasRows) {
                throw new ItemNotFoundException();
            }

            reader.Read();
            var transformed = this.transformer.transform(reader);
            reader.Close();

            return transformed;
        }
    }
}
