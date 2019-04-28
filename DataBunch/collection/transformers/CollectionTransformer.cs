using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.collection.models;
using DataBunch.foundation.db;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.collection.transformers
{
    public class CollectionTransformer: Transformer<Collection>
    {
        protected override Collection parseData(SqlDataReader reader)
        {
            return new Collection(
                (long) reader["id"],
                (string) reader["name"],
                (long) reader["user_id"],
                (long) reader["parent_id"],
                (string) reader["type"],
                (string) reader["created_at"],
                (string) reader["updated_at"],
                (int) reader["size"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "id", SqlDbType.Int },
                { "name", SqlDbType.VarChar },
                { "user_id", SqlDbType.Int },
                { "created_at", SqlDbType.DateTime },
                { "updated_at", SqlDbType.DateTime },
                { "type", SqlDbType.VarChar },
                { "size", SqlDbType.Int }
            };
        }

        public override DbParams getDbParams(Collection model)
        {
            return new DbParams(new DbParam[] {
                new DbParam("name", model.Name, this.getParamType("name")),
                new DbParam("user_id", model.UserID, this.getParamType("user_id")),
                new DbParam("type", model.Type, this.getParamType("type")),
                new DbParam("size", model.Size, this.getParamType("size")),
                new DbParam("created_at", model.CreatedAt, this.getParamType("created_at")),
                new DbParam("updated_at", model.UpdatedAt, this.getParamType("updated_at"))
            });
        }
    }
}
