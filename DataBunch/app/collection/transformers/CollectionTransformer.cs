using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.app.collection.models;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.transformers;

namespace DataBunch.app.collection.transformers
{
    public class CollectionTransformer: Transformer<Collection>
    {
        protected override Collection parseData(SqlDataReader reader)
        {
            return new Collection(
                (int) reader["id"],
                (string) reader["name"],
                (string) reader["path"],
                (int) reader["user_id"],
                (int) reader["parent_id"],
                (string) reader["type"],
                (DateTime) reader["created_at"],
                (DateTime) reader["updated_at"],
                (int) reader["size"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "id", SqlDbType.Int },
                { "name", SqlDbType.VarChar },
                { "path", SqlDbType.VarChar },
                { "user_id", SqlDbType.Int },
                { "parent_id", SqlDbType.Int },
                { "created_at", SqlDbType.DateTime },
                { "updated_at", SqlDbType.DateTime },
                { "type", SqlDbType.VarChar },
                { "size", SqlDbType.Int }
            };
        }

        public override DbParams getDbParams(Collection model)
        {
            return new DbParams(new[] {
                new DbParam("name", model.Name, this.getParamType("name")),
                new DbParam("path", model.Path, this.getParamType("path")),
                new DbParam("user_id", model.UserID, this.getParamType("user_id")),
                new DbParam("parent_id", model.ParentID, this.getParamType("parent_id")), 
                new DbParam("type", model.Type, this.getParamType("type")),
                new DbParam("size", model.Size, this.getParamType("size")),
            });
        }
    }
}
