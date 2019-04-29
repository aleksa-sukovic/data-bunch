using System.Windows.Forms;
using DataBunch.app.foundation.utils;

namespace DataBunch.app.ui.forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void onFormLoad(object sender, System.EventArgs e)
        {
            ConsoleManager.Show();
        }
    }
}
