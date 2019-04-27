using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataBunch.foundation.db;
using DataBunch.foundation.processors.query;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.facades
{
    public class DB
    {
        public static void all(string tableName, DbParams searchParams)
        {
            var queryProcessor = new SearchQueryProcessor();
            var command = queryProcessor.process(tableName, searchParams);

            Log.info("Searching with query: " + queryProcessor.getLastQuery());
            command.ExecuteNonQuery();
            Log.success("Successfully executed query.");
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
            var affectedId = (int) command.ExecuteScalar();
            Log.success("Successfully executed query.");

            return affectedId;
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
