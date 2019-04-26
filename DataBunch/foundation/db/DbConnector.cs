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

        private static bool connected;
        private static SqlConnection connection;

        public void connect()
        {
            if (connected) {
                return;
            }

            DbConnector.connection = new SqlConnection(getConnectionString());
            DbConnector.connection.Open();
            DbConnector.connected = true;
            Log.info("Successfully connected to database.");
        }

        public static SqlConnection getConnection()
        {
            return connection;
        }

        private string getConnectionString()
        {
            return "user id=" + DB_USER + ";"
                           + "server=" + DB_SERVER + ";"
                           + "Trusted_Connection=" + DB_CONNECTION_TYPE + ";"
                           + "database=" + DB_DATABASE + ";"
                           + "connection timeout=" + DB_TIMEOUT;
        }
    }
}
