using System.Windows.Forms;

namespace DataBunch.app.ui.controls.users
{
    public partial class UsersControl : UserControl
    {
        private static UsersControl instance;
        private const string id = "users-control";
        private const string label = "Users";

        public static UsersControl Instance => instance ?? (instance = new UsersControl());
        public static string Label => label;
        public static string ID => id;
        public UsersControl()
        {
            InitializeComponent();
        }
    }
}

