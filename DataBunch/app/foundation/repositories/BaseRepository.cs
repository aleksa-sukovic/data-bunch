using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using DataBunch.foundation.db;
using DataBunch.foundation.db.facades;
using DataBunch.foundation.exceptions;
using DataBunch.foundation.models;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.repositories
{
    public abstract class BaseRepository<T> where T: Model
    {
        protected string tableName = "";
        protected Transformer<T> transformer;

        public List<T> all(List<QueryParam> queryParams, bool withIncludes = true)
        {
            // transform queryParams to DbParams
            var dbParams = new DbParams();
            foreach (var param in queryParams) {
                dbParams.add(new DbParam(param.Name, param.Value, this.transformer.getParamType(param.Name), param.Operator, param.BooleanOpr));
            }

            // read data
            var reader = DB.all(this.tableName, dbParams);
            var result = new List<T>();

            while (reader.Read()) {
                var transformed = this.transformer.transform(reader);
                transformed = withIncludes ? this.addIncludes(transformed) : transformed;
                result.Add(transformed);
            }

            reader.Close();
            return result;
        }

        public FluentQuery<T> query()
        {
            return new FluentQuery<T>(this.tableName, this.transformer, this);
        }

        public T one(long id, bool withIncludes = true)
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

            return withIncludes ? this.addIncludes(transformed) : transformed;
        }

        public T save(T model)
        {
            if (model.isNull()) {
                return this.create(model);
            }

            return this.update(model);
        }

        public List<T> saveMany(List<T> values)
        {
            var result = new List<T>();

            foreach (var value in values) {
                result.Add(this.save(value));
            }

            return result;
        }

        public T create(T model)
        {
            // adding timestamps
            var valueParams = this.transformer.getDbParams(model);
            valueParams.add(new DbParam("created_at", DateTime.Now.ToString(CultureInfo.InvariantCulture), SqlDbType.DateTime));
            valueParams.add(new DbParam("updated_at", DateTime.Now.ToString(CultureInfo.InvariantCulture), SqlDbType.DateTime));

            // updating
            var insertedId = DB.create(this.tableName, valueParams);
            var saved = this.one(insertedId);
            this.afterSave(model, saved);

            return saved;
        }

        public List<T> createMany(List<T> values)
        {
            var result = new List<T>();

            foreach (var value in values) {
                result.Add(this.create(value));
            }

            return result;
        }

        public List<T> updateMany(List<T> values)
        {
            var result = new List<T>();

            foreach (var value in values) {
                result.Add(this.update(value));
            }

            return result;
        }

        public T update(T model)
        {
            // adding update restriciton
            var searchParams = new DbParams(new[] {
                new DbParam("id", model.ID, this.transformer.getParamType("id")),
            });

            // adding timestamps
            var valueParams = this.transformer.getDbParams(model);
            valueParams.remove("created_at");
            valueParams.add(new DbParam("updated_at", DateTime.Now.ToString(CultureInfo.InvariantCulture), SqlDbType.DateTime));

            // updating
            DB.update(this.tableName, this.transformer.getDbParams(model), searchParams);
            var saved = this.one(model.ID);
            this.afterSave(model, saved);

            return saved;
        }

        public T delete(T model)
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

        public virtual T addIncludes(T model)
        {
            return model;
        }

        protected virtual void afterSave(T beforeSave, T afterSave)
        {
            //
        }
    }
}
