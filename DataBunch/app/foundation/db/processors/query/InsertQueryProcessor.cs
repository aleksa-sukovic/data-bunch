using System.Data.SqlClient;

namespace DataBunch.app.foundation.db.processors.query
{
    public class InsertQueryProcessor: QueryProcessor
    {
        public SqlCommand process(string tableName, DbParams valueParams)
        {
            var query = constructBaseQuery(tableName) + constructParamNames(valueParams);
            var queryValues = constructParamValues(valueParams);

            lastQuery = query + " OUTPUT INSERTED.ID VALUES " + queryValues;

            return constructCommand(lastQuery, valueParams);
        }

        private string constructBaseQuery(string tableName)
        {
            return "INSERT INTO " + tableName + " ";
        }

        private string constructParamNames(DbParams valueParams)
        {
            var query = "(";

            foreach (var pair in valueParams.get()) {
                query += pair.Name + ", ";
            }

            return query.Substring(0, query.Length - 2) + ")";
        }

        private string constructParamValues(DbParams valueParams)
        {
            var query = "(";

            foreach (var pair in valueParams.get()) {
                query += "@" + pair.ID + ", ";
            }

            return query.Substring(0, query.Length - 2) + ")";
        }
    }
}
