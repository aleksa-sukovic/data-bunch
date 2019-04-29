using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.foundation.db;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;
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
                (int) reader["age"],
                (string) reader["privilege"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "name", SqlDbType.VarChar },
                { "age", SqlDbType.Int },
                { "id", SqlDbType.Int },
                { "privilege", SqlDbType.VarChar }
            };
        }

        public override DbParams getDbParams(User model)
        {
            return new DbParams(new DbParam[] {
                new DbParam("name", model.Name, this.getParamType("name")),
                new DbParam("age", model.Age,  this.getParamType("age")),
                new DbParam("privilege", model.Privilege, this.getParamType("privilege")),
            });
        }
    }
}
