using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            if (!exists) {
                throw new TransformException("Parameter {" + param + "} does not have matching type.");
            }

            return type;
        }
    }
}
