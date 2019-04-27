using System.Data.SqlClient;
using DataBunch.foundation.db;

namespace DataBunch.foundation.processors.query
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
            return "SELECT * FROM " + tableName + " ";
        }
    }
}
