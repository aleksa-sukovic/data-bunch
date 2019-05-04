using System.Windows.Forms;

namespace DataBunch.app.ui.controls.auth
{
    public partial class AuthControl : UserControl
    {
        private static AuthControl instance;
        private const string id = "auth-control";
        private const string label = "Authentification";

        public static AuthControl Instance => instance ?? (instance = new AuthControl());
        public static string Label => label;
        public static string ID => id;

        private AuthControl()
        {
            InitializeComponent();
        }
    }
}

