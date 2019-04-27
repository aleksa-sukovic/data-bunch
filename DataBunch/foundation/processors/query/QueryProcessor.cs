using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.foundation.db;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.processors.query
{
    public class QueryProcessor
    {
        protected string lastQuery;

        protected SqlCommand constructCommand(string query, DbParams valueParams)
        {
            var command = new SqlCommand { Connection = DbConnector.getConnection(), CommandText = query };

            foreach (var pair in valueParams.get()) {
                command.Parameters.AddWithValue(pair.ID, pair.Type);
                command.Parameters[pair.ID].Value = pair.Value;
            }

            return command;
        }

        protected object constructSearchParams(DbParams searchParams)
        {
            if (searchParams.count() == 0) {
                return "";
            }

            var query = " WHERE ";
            var index = 0;

            foreach (var pair in searchParams.get()) {
                if (index++ != 0) {
                    query += pair.BooleanOpr + " ";
                }

                query += pair.Name + " " + pair.Operator + " ";

                if (pair.Type == SqlDbType.VarChar || pair.Type == SqlDbType.Char || pair.Type == SqlDbType.NChar ||
                    pair.Type == SqlDbType.NVarChar) {
                    query += "'" + pair.Value + "' ";
                } else {
                    query += pair.Value + " ";
                }
            }

            return query.Substring(0, query.Length - 1);
        }

        protected string constructSearchParamValue(DbParam param)
        {
            if (param.Type == SqlDbType.VarChar || param.Type == SqlDbType.Char || param.Type == SqlDbType.NChar ||
                param.Type == SqlDbType.NVarChar) {
                return "'" + param.Value + "' ";
            }

            return param.Value + " ";
        }

        public string getLastQuery()
        {
            return this.lastQuery;
        }
    }
}
