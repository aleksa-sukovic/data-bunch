using System.Collections.Generic;
using System.Windows.Forms;
using DataBunch.app.policies.models;
using DataBunch.app.ui.services;

namespace DataBunch.app.ui.controls.policies
{
    public partial class PoliciesControl : UserControl, Refreshable<Policy>
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

        public void refresh(List<Policy> toShow = null)
        {
            //
        }
    }
}

