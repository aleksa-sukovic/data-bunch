using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.foundation.db;
using DataBunch.foundation.exceptions;

namespace DataBunch.foundation.transformers
{
    public abstract class Transformer<Model>
    {
        private readonly Dictionary<string, SqlDbType> paramTypeMap;

        protected Transformer()
        {
            this.paramTypeMap = this.getParamTypeMap();
        }

        protected abstract Model parseData(SqlDataReader reader);
        protected abstract Dictionary<string, SqlDbType> getParamTypeMap();
        public abstract DbParams getDbParams(Model model);

        public Model transform(SqlDataReader reader)
        {
            try {
                return parseData(reader);
            } catch (Exception exception) {
                throw new TransformException(exception.Message);
            }
        }

        public SqlDbType getParamType(string param)
        {
            var exists = this.paramTypeMap.TryGetValue(param, out var type);

            return !exists ? SqlDbType.Int : type;
        }
    }
}
