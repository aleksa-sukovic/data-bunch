using System;
using System.Data.SqlClient;
using DataBunch.foundation.exceptions;

namespace DataBunch.foundation.transformers
{
    public abstract class Transformer<Model>
    {
        public Model transform(SqlDataReader reader)
        {
            try {
                return parseData(reader);
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                throw new TransformException(exception.Message);
            }
        }

        protected abstract Model parseData(SqlDataReader reader);
    }
}
