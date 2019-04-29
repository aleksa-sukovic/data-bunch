using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.transformers;
using DataBunch.app.sessions.models;

namespace DataBunch.app.sessions.transformers
{
    public class SessionTransformer: Transformer<Session>
    {
        protected override Session parseData(SqlDataReader reader)
        {
            return new Session(
                (int) reader["id"],
                (int) reader["user_id"],
                (string) reader["action"],
                (bool) reader["active"],
                (DateTime) reader["created_at"],
                (DateTime) reader["updated_at"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "id", SqlDbType.Int },
                { "user_id", SqlDbType.Int },
                { "action", SqlDbType.VarChar },
                { "active", SqlDbType.Bit },
                { "created_at", SqlDbType.DateTime },
                { "updated_at", SqlDbType.DateTime }
            };
        }

        public override DbParams getDbParams(Session model)
        {
            return new DbParams(new [] {
                new DbParam("user_id", model.UserID, this.getParamType("user_id")),
                new DbParam("action", model.Action, this.getParamType("action")),
                new DbParam("active", model.Active ? 1 : 0, this.getParamType("active")),
            });
        }
    }
}
