using System.Windows.Forms;

namespace DataBunch.app.ui.controls.collections
{
    public partial class CollectionsControl : UserControl
    {
        private static CollectionsControl instance;
        private const string id = "collections-control";
        private const string label = "Collections";

        public static CollectionsControl Instance => instance ?? (instance = new CollectionsControl());
        public static string Label => label;
        public static string ID => id;

        private CollectionsControl()
        {
            InitializeComponent();
        }
    }
}

