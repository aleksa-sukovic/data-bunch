using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;

namespace DataBunch.app.ui.forms
{
    public partial class WelcomeForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void onFormLoad(object sender, System.EventArgs e)
        {
            ConsoleManager.Show();
            Auth.init();
        }
    }
}
