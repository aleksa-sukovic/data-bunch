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
        }
    }
}
