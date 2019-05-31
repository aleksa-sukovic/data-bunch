using System.Data.SqlClient;

namespace DataBunch.app.foundation.db.processors.query
{
    public class SearchQueryProcessor: QueryProcessor
    {
        public SqlCommand process(string tableName, DbParams searchParams)
        {
            var query = constructBaseQuery(tableName);

            lastQuery = query + constructSearchParams(searchParams);

            return constructCommand(lastQuery, searchParams);
        }

        private string constructBaseQuery(string tableName)
        {
            return "SELECT * FROM " + tableName + " BASE_TABLE ";
        }
    }
}
