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
        public static void save(string tableName, Dictionary<string, KeyValuePair<object, SqlDbType>> valueParams)
        {
            var queryProcessor = new InsertQueryProcessor();
            var command = queryProcessor.process(tableName, valueParams);

            Log.info("Inserting with query: " + queryProcessor.getLastQuery());
            command.ExecuteNonQuery();
        }
    }
}
