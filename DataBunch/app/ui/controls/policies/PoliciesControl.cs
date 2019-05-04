using System.Windows.Forms;

namespace DataBunch.app.ui.controls.policies
{
    public partial class PoliciesControl : UserControl
    {
        private static PoliciesControl instance;
        private const string id = "policies-control";
        private const string label = "Policies";

        public static PoliciesControl Instance => instance ?? (instance = new PoliciesControl());
        public static string Label => label;
        public static string ID => id;
        public PoliciesControl()
        {
            InitializeComponent();
        }
    }
}

