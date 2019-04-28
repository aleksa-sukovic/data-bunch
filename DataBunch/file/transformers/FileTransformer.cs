using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.file.models;
using DataBunch.foundation.db;
using DataBunch.foundation.transformers;
using DataBunch.foundation.utils;

namespace DataBunch.file.transformers
{
    public class FileTransformer: Transformer<File>
    {
        protected override File parseData(SqlDataReader reader)
        {
            return new File(
                 (long) reader["id"],
                 (string) reader["path"],
                 (string) reader["name"],
                 (string) reader["type"],
                 (long) reader["collection_id"],
                 (string) reader["created_at"],
                 (string) reader["updated_at"]
            );
        }

        protected override Dictionary<string, SqlDbType> getParamTypeMap()
        {
            return new Dictionary<string, SqlDbType> {
                { "id", SqlDbType.Int },
                { "name", SqlDbType.VarChar },
                { "type", SqlDbType.VarChar },
                { "collection_id", SqlDbType.Int },
                { "created_at", SqlDbType.DateTime },
                { "updated_at", SqlDbType.DateTime }
            };
        }

        public override DbParams getDbParams(File model)
        {
            return new DbParams(new DbParam[] {
                new DbParam("name", model.Name, this.getParamType("name")),
                new DbParam("type", model.Type, this.getParamType("type")),
                new DbParam("collection_id", model.CollectionID, this.getParamType("collection_id")),
                new DbParam("created_at", model.CreatedAt, this.getParamType("created_at")),
                new DbParam("updated_at", model.UpdatedAt, this.getParamType("updated_at"))
            });
        }
    }
}
