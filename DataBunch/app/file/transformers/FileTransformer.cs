using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.app.file.models;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.transformers;

namespace DataBunch.app.file.transformers
{
    public class FileTransformer: Transformer<File>
    {
        protected override File parseData(SqlDataReader reader)
        {
            return new File(
                 (int) reader["id"],
                 (string) reader["path"],
                 (string) reader["name"],
                 (string) reader["type"],
                 (int) reader["collection_id"],
                 (DateTime) reader["created_at"],
                 (DateTime) reader["updated_at"]
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
                { "updated_at", SqlDbType.DateTime },
                { "path", SqlDbType.VarChar }
            };
        }

        public override DbParams getDbParams(File model)
        {
            return new DbParams(new DbParam[] {
                new DbParam("path", model.Path, this.getParamType("path")),
                new DbParam("name", model.Name, this.getParamType("name")),
                new DbParam("type", model.Type, this.getParamType("type")),
                new DbParam("collection_id", model.CollectionID, this.getParamType("collection_id")),
            });
        }
    }
}
