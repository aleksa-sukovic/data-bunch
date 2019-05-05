using System.Windows.Forms;
using DataBunch.app.ui.services;

namespace DataBunch.app.ui.controls.files
{
    public partial class FilesControl : UserControl, Refreshable
    {
        private static FilesControl instance;
        private const string id = "files-control";
        private const string label = "Files";

        public static FilesControl Instance => instance ?? (instance = new FilesControl());
        public static string Label => label;
        public static string ID => id;

        public FilesControl()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            //
        }
    }
}

