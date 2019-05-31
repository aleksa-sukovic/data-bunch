using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.transformers;
using DataBunch.app.user.models;

namespace DataBunch.app.user.transformers
{
    public class UserTransformer: Transformer<User>
    {
        protected override User parseData(SqlDataReader reader)
        {
            return new User(
                (int) reader["id"],
                (string) reader["username"],
                (string) reader["password"],
                Convert.ToString(reader["name"]),
                (int) reader["age"],
                (string) reader["privilege"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "username", SqlDbType.VarChar },
                { "password", SqlDbType.VarChar },
                { "name", SqlDbType.VarChar },
                { "age", SqlDbType.Int },
                { "id", SqlDbType.Int },
                { "privilege", SqlDbType.VarChar }
            };
        }

        public override DbParams getDbParams(User model)
        {
            return new DbParams(new[] {
                new DbParam("name", model.Name, this.getParamType("name")),
                new DbParam("age", model.Age,  this.getParamType("age")),
                new DbParam("privilege", model.Privilege, this.getParamType("privilege")),
                new DbParam("username", model.Username, this.getParamType("username")),
                new DbParam("password", model.Password, this.getParamType("password"))
            });
        }
    }
}
