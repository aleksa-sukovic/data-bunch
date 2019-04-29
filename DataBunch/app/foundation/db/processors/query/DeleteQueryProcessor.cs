using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.foundation.db;
using DataBunch.foundation.db.processors.query;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.processors.query
{
    public class DeleteQueryProcessor: QueryProcessor
    {
        public SqlCommand process(string tableName, DbParams searchParams)
        {
            var query = constructBaseQuery(tableName);

            lastQuery = query + constructSearchParams(searchParams);

            return constructCommand(lastQuery, searchParams);
        }

        private string constructBaseQuery(string tableName)
        {
            return "DELETE " + tableName + " ";
        }
    }
}
