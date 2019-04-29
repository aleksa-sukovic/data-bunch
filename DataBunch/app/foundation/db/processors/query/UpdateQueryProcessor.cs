using System.Data.SqlClient;
using DataBunch.foundation.processors.query;

namespace DataBunch.foundation.db.processors.query
{
    public class UpdateQueryProcessor: QueryProcessor
    {
        public SqlCommand process(string tableName, DbParams valueParams, DbParams searchParams)
        {
            var query = constructBaseQuery(tableName);

            lastQuery = query + constructParamQuery(valueParams);
            lastQuery = lastQuery + constructSearchParams(searchParams);

            return constructCommand(lastQuery, valueParams);
        }

        private object constructParamQuery(DbParams valueParams)
        {
            var query = "";

            foreach (var pair in valueParams.get()) {
                if (pair.Name == "id") {
                    continue;
                }

                query += pair.Name + "=@" + pair.ID + ", ";
            }

            return query.Substring(0, query.Length - 2);
        }

        private string constructBaseQuery(string tableName)
        {
            return "UPDATE " + tableName + " SET ";
        }
    }
}
