using System;
using System.Data.SqlClient;

namespace DataBunch.foundation.db
{
    public class DbConnector
    {
        private static string DB_USER = "ALEKSAWDTC/Aleksa";
        private static string DB_SERVER = "ALEKSAWDTC";
        private static string DB_CONNECTION_TYPE = "Trusted_Connection=yes";
        private static string DB_DATABASE = "data_bunch";
        private static string DB_TIMEOUT = "connection timeout=5";

        private static bool connected;
        private static SqlConnection connection;

        public void connect()
        {
            if (isConnected()) {
                return;
            }

            DbConnector.connection = new SqlConnection(getConnectionString());
            DbConnector.connection.Open();
            DbConnector.connected = true;
            Console.WriteLine("Connected");
        }

        public bool isConnected()
        {
            return DbConnector.connected;
        }

        protected string getConnectionString()
        {
            return DB_USER + ";"
                           + DB_SERVER + ";"
                           + DB_CONNECTION_TYPE + ";"
                           + DB_DATABASE + ";"
                           + DB_TIMEOUT;
        }
    }
}
