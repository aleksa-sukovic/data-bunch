using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataBunch.foundation.db;
using DataBunch.foundation.facades;
using DataBunch.foundation.utils;

namespace DataBunch.ui.forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private static void InitializeDatabase()
        {
            var dbConnector = new DbConnector();

            dbConnector.connect();
        }

        private void onFormLoad(object sender, System.EventArgs e)
        {
            ConsoleManager.Show();

            InitializeDatabase();

            testInsert();
        }

        private void testInsert()
        {
            var userParams = new Dictionary<string, KeyValuePair<object, SqlDbType>>();

            userParams.Add("name", new KeyValuePair<object, SqlDbType>("Aleksa", SqlDbType.VarChar));
            userParams.Add("age", new KeyValuePair<object, SqlDbType>(21, SqlDbType.Int));

            DB.save("users", userParams);
        }
    }
}
