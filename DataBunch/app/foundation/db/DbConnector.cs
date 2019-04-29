using System;
using System.Data.SqlClient;
using DataBunch.foundation.utils;

namespace DataBunch.foundation.db
{
    public class DbConnector
    {
        private static string DB_USER = "ALEKSAWDTC";
        private static string DB_SERVER = "ALEKSAWDTC\\ALEKSAWDTC";
        private static string DB_CONNECTION_TYPE = "yes";
        private static string DB_DATABASE = "data_bunch";
        private static string DB_TIMEOUT = "5";
        private static string DB_MULTIPLE_ACTIVE_RESULTS = "true";

        private static SqlConnection connection;

        public static SqlConnection getConnection()
        {
            if (connection == null) {
                connection = new SqlConnection(getConnectionString());
                connection.Open();
                Log.info("Successfully created new database connection.");
            }

            return connection;
        }

        private static string getConnectionString()
        {
            return "user id=" + DB_USER + ";"
                           + "server=" + DB_SERVER + ";"
                           + "Trusted_Connection=" + DB_CONNECTION_TYPE + ";"
                           + "database=" + DB_DATABASE + ";"
                           + "connection timeout=" + DB_TIMEOUT + ";"
                           + "MultipleActiveResultSets=" + DB_MULTIPLE_ACTIVE_RESULTS;
        }
    }
}
