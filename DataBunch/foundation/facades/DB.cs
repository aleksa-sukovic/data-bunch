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
        public static void save(string tableName, DbParams valueParams, DbParams searchParams = null)
        {
            if (searchParams == null) {
                create(tableName, valueParams);

                return;
            }

            update(tableName, valueParams, searchParams);
        }

        public static void create(string tableName, DbParams valueParams)
        {
            var queryProcessor = new InsertQueryProcessor();
            var command = queryProcessor.process(tableName, valueParams);

            Log.info("Inserting with query: " + queryProcessor.getLastQuery());
            command.ExecuteNonQuery();
            Log.success("Successfully executed query.");
        }

        public static void update(string tableName, DbParams valueParams, DbParams searchParams)
        {
            var queryProcessor = new UpdateQueryProcessor();
            var command = queryProcessor.process(tableName, valueParams, searchParams);

            Log.info("Updating with query: " + queryProcessor.getLastQuery());
            command.ExecuteNonQuery();
            Log.success("Successfully executed query.");
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
