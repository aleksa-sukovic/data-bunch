using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.foundation.transformers;
using DataBunch.user.models;

namespace DataBunch.user.transformers
{
    public class UserTransformer: Transformer<User>
    {
        protected override User parseData(SqlDataReader reader)
        {
            return new User(
                (int) reader["id"],
                (string) reader["name"],
                (int) reader["age"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "name", SqlDbType.VarChar },
                { "age", SqlDbType.Int },
                { "id", SqlDbType.Int }
            };
        }
    }
}
