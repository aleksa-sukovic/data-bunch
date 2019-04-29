using System.Data.SqlClient;
using DataBunch.app.foundation.db.processors.query;
using DataBunch.app.foundation.utils;

namespace DataBunch.app.foundation.db.facades
{
    public static class DB
    {
        public static SqlDataReader all(string tableName, DbParams searchParams)
        {
            var queryProcessor = new SearchQueryProcessor();
            var command = queryProcessor.process(tableName, searchParams);

            Log.info("Searching with query: " + queryProcessor.getLastQuery());
            var reader = command.ExecuteReader();
            Log.success("Successfully executed query.");

            return reader;
        }

        public static int save(string tableName, DbParams valueParams, DbParams searchParams = null)
        {
            if (searchParams == null) {
                return create(tableName, valueParams);
            }

            return update(tableName, valueParams, searchParams);
        }

        public static int create(string tableName, DbParams valueParams)
        {
            var queryProcessor = new InsertQueryProcessor();
            var command = queryProcessor.process(tableName, valueParams);

            Log.info("Inserting with query: " + queryProcessor.getLastQuery());
            var affectedId = (int) command.ExecuteScalar();
            Log.success("Successfully executed query. Inserted id => " + affectedId);

            return affectedId;
        }

        public static int update(string tableName, DbParams valueParams, DbParams searchParams)
        {
            var queryProcessor = new UpdateQueryProcessor();
            var command = queryProcessor.process(tableName, valueParams, searchParams);

            Log.info("Updating with query: " + queryProcessor.getLastQuery());
            command.ExecuteNonQuery();
            Log.success("Successfully executed query.");

            return 0;
        }

        public static void delete(string tableName, DbParams searchParams)
        {
            var queryProcessor = new DeleteQueryProcessor();
            var command = queryProcessor.process(tableName, searchParams);

            Log.info("Deleting with query: " + queryProcessor.getLastQuery());
            command.ExecuteNonQuery();
            Log.success("Successfully executed query.");
        }
    }
}
