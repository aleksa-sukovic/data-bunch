using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.app.policies.models;
using DataBunch.foundation.db;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.app.policies.transformers
{
    public class PolicyTransformer: Transformer<Policy>
    {
        protected override Policy parseData(SqlDataReader reader)
        {
            return new Policy(
                (int) reader["id"],
                (int) reader["user_id"],
                (int) reader["target_id"],
                (string) reader["type"],
                (DateTime) reader["created_at"],
                (DateTime) reader["updated_at"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "id", SqlDbType.Int },
                { "user_id", SqlDbType.Int },
                { "target_id", SqlDbType.Int },
                { "type", SqlDbType.VarChar },
                { "created_at", SqlDbType.DateTime },
                { "updated_at", SqlDbType.DateTime }
            };
        }

        public override DbParams getDbParams(Policy model)
        {
            return new DbParams(new[] {
                new DbParam("user_id", model.UserID, this.getParamType("user_id")),
                new DbParam("target_id", model.TargetID, this.getParamType("target_id")),
                new DbParam("type", model.Type, this.getParamType("type")),
            });
        }
    }
}
