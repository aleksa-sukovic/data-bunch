using System;
using System.Collections.Generic;
using System.Data;
using DataBunch.foundation.db;
using DataBunch.foundation.db.facades;
using DataBunch.foundation.exceptions;
using DataBunch.foundation.models;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.repositories
{
    public abstract class BaseRepository<Object> where Object: Model
    {
        protected string tableName = "";
        protected Transformer<Object> transformer;
        private readonly FluentQuery<Object> fluentQuery;

        public List<Object> all(List<QueryParam> queryParams)
        {
            // transform queryParams to DbParams
            var dbParams = new DbParams();
            foreach (var param in queryParams) {
                dbParams.add(new DbParam(param.Name, param.Value, this.transformer.getParamType(param.Name), param.Operator, param.BooleanOpr));
            }

            // read data
            var reader = DB.all(this.tableName, dbParams);
            var result = new List<Object>();

            while (reader.Read()) {
                result.Add(this.transformer.transform(reader));
            }

            reader.Close();
            return result;
        }

        public FluentQuery<Object> query()
        {
            return new FluentQuery<Object>(this.tableName, this.transformer);
        }

        public Object one(long id)
        {
            var reader = DB.all(this.tableName, new DbParams(new DbParam[] {
                new DbParam("id", id, this.transformer.getParamType("id")),
            }));

            if (!reader.HasRows) {
                throw new ItemNotFoundException();
            }

            reader.Read();
            var transformed = transformer.transform(reader);
            reader.Close();

            return transformed;
        }

        public Object save(Object model)
        {
            if (model.isNull()) {
                return this.create(model);
            }

            return this.update(model);
        }

        public List<Object> saveMany(List<Object> values)
        {
            var result = new List<Object>();

            foreach (var value in values) {
                result.Add(this.save(value));
            }

            return result;
        }

        public Object create(Object model)
        {
            var newId = DB.create(this.tableName, this.transformer.getDbParams(model));

            return this.one(newId);
        }

        public List<Object> createMany(List<Object> values)
        {
            var result = new List<Object>();

            foreach (var value in values) {
                result.Add(this.create(value));
            }

            return result;
        }

        public List<Object> updateMany(List<Object> values)
        {
            var result = new List<Object>();

            foreach (var value in values) {
                result.Add(this.update(value));
            }

            return result;
        }

        public Object update(Object model)
        {
            var searchParams = new DbParams(new[] {
                new DbParam("id", model.ID, this.transformer.getParamType("id")),
            });

            Console.WriteLine(searchParams);

            DB.update(this.tableName, this.transformer.getDbParams(model), searchParams);

            return this.one(model.ID);
        }

        public Object delete(Object model)
        {
            var searchParams = new DbParams(new DbParam[] {
                new DbParam("id", model.ID, this.transformer.getParamType("id")),
            });

            DB.delete(this.tableName, searchParams);

            return model;
        }

        public void deleteById(long id)
        {
            var searchParams = new DbParams(new DbParam[] {
                new DbParam("id", id, this.transformer.getParamType("id")),
            });

            DB.delete(this.tableName, searchParams);
        }
    }
}
