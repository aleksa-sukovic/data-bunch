using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.foundation.db;

namespace DataBunch.foundation.processors.query
{
    public class InsertQueryProcessor
    {
        private string lastQuery;

        public SqlCommand process(string tableName, Dictionary<string, KeyValuePair<object, SqlDbType>> valueParams)
        {
            var query = constructBaseQuery(tableName) + constructParamNames(valueParams);
            var queryValues = constructParamValues(valueParams);

            lastQuery = query + " VALUES " + queryValues;

            return constructCommand(lastQuery, valueParams);
        }

        public string getLastQuery()
        {
            return this.lastQuery;
        }

        private string constructBaseQuery(string tableName)
        {
            return "INSERT INTO " + tableName + " ";
        }

        private string constructParamNames(Dictionary<string, KeyValuePair<object, SqlDbType>> valueParams)
        {
            var query = "(";

            foreach (var pair in valueParams) {
                query += pair.Key + ", ";
            }

            return query.Substring(0, query.Length - 2) + ")";
        }

        private string constructParamValues(Dictionary<string, KeyValuePair<object, SqlDbType>> valueParams)
        {
            var query = "(";

            foreach (var pair in valueParams) {
                query += "@" + pair.Key + ", ";
            }

            return query.Substring(0, query.Length - 2) + ")";
        }

        private SqlCommand constructCommand(string query, Dictionary<string, KeyValuePair<object, SqlDbType>> valueParams)
        {
            var command = new SqlCommand { Connection = DbConnector.getConnection(), CommandText = query };

            foreach (var pair in valueParams) {
                command.Parameters.AddWithValue(pair.Key, pair.Value.Value);
                command.Parameters[pair.Key].Value = pair.Value.Key;
            }

            return command;
        }
    }
}
