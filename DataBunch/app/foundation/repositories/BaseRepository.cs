using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.db.facades;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.foundation.models;
using DataBunch.app.foundation.transformers;
using DataBunch.app.policies.handlers;

namespace DataBunch.app.foundation.repositories
{
    public abstract class BaseRepository<T> where T: Model
    {
        protected string tableName = "";
        protected Transformer<T> transformer;
        protected PolicyHandler<T> policy;

        public List<T> all(List<QueryParam> queryParams, bool withIncludes = true)
        {
            if (!policy.checkList(typeof(T))) {
                throw new UnauthorizedException("You do not have permission to list requested resources.");
            }

            // transform queryParams to DbParams
            var dbParams = new DbParams();
            foreach (var param in queryParams) {
                dbParams.add(new DbParam(param.Name, param.Value, this.transformer.getParamType(param.Name), param.Operator, param.BooleanOpr));
            }

            // read data
            var reader = DB.all(this.tableName, manipulateParams(dbParams));
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
            if (!policy.checkShow(id)) {
                throw new UnauthorizedException("You do not have permission to view requested resource.");
            }

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
            if (!policy.checkCreate(typeof(T))) {
                throw new UnauthorizedException("You do not have permission to create resources of type '" + typeof(T) + "'");
            }

            // adding timestamps
            var valueParams = this.transformer.getDbParams(model);
            valueParams.add(new DbParam("created_at", DateTime.Now.ToString(CultureInfo.InvariantCulture), SqlDbType.DateTime));
            valueParams.add(new DbParam("updated_at", DateTime.Now.ToString(CultureInfo.InvariantCulture), SqlDbType.DateTime));

            // updating
            this.beforeSave(model);
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
            if (!policy.checkUpdate(model.ID)) {
                throw new UnauthorizedException("You do not have permission to update this resource.");
            }

            // adding update restriciton
            var searchParams = new DbParams(new[] {
                new DbParam("id", model.ID, this.transformer.getParamType("id")),
            });

            // adding timestamps
            var valueParams = this.transformer.getDbParams(model);
            valueParams.remove("created_at");
            valueParams.add(new DbParam("updated_at", DateTime.Now.ToString(CultureInfo.InvariantCulture), SqlDbType.DateTime));

            // updating
            this.beforeSave(model);
            DB.update(this.tableName, this.transformer.getDbParams(model), searchParams);
            var saved = this.one(model.ID);
            this.afterSave(model, saved);

            return saved;
        }

        public T delete(T model)
        {
            if (!policy.checkDelete(model.ID)) {
                throw new UnauthorizedException("You do not have permission to delete this resource");
            }

            var searchParams = new DbParams(new DbParam[] {
                new DbParam("id", model.ID, this.transformer.getParamType("id")),
            });

            DB.delete(this.tableName, searchParams);

            return model;
        }

        public void deleteById(long id)
        {
            if (!policy.checkDelete(id)) {
                throw new UnauthorizedException("You do not have permission to delete this resource");
            }

            var searchParams = new DbParams(new DbParam[] {
                new DbParam("id", id, this.transformer.getParamType("id")),
            });

            DB.delete(this.tableName, searchParams);
        }

        public virtual T addIncludes(T model)
        {
            return model;
        }

        protected virtual void beforeSave(T item)
        {
            //
        }

        protected virtual void afterSave(T beforeSave, T afterSave)
        {
            //
        }

        protected virtual DbParams manipulateParams(DbParams dbParams)
        {
            return dbParams;
        }

        public Transformer<T> getTransformer()
        {
            return this.transformer;
        }
    }
}
