using System.Data;
using System.Data.SqlClient;

namespace DataBunch.foundation.db.processors.query
{
    public class QueryProcessor
    {
        protected string lastQuery;

        protected SqlCommand constructCommand(string query, DbParams valueParams)
        {
            var command = new SqlCommand { Connection = DbConnector.getConnection(), CommandText = query };

            foreach (var pair in valueParams.get()) {
                if (pair.Value == null) {
                    continue;
                }

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
                query += isStringType(pair.Type) ? "'" + pair.Value + "' " : pair.Value + " ";
            }

            return query.Substring(0, query.Length - 1);
        }

        public string getLastQuery()
        {
            return this.lastQuery;
        }

        private bool isStringType(SqlDbType type)
        {
            return type == SqlDbType.VarChar || type == SqlDbType.Char || type == SqlDbType.NChar || type == SqlDbType.NVarChar;
        }
    }
}
