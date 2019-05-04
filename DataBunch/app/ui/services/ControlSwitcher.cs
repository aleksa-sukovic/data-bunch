using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DataBunch.app.ui.controls.auth;
using DataBunch.app.ui.controls.collections;
using DataBunch.app.ui.controls.files;
using DataBunch.app.ui.controls.policies;
using DataBunch.app.ui.controls.users;

namespace DataBunch.app.ui.services
{
    public class ControlSwitcher
    {
        private Form form;

        public ControlSwitcher(Form form)
        {
            this.form = form;
        }

        public void switchToPanel(string tag)
        {
            if (tag == AuthControl.ID) {
                enablePanel(AuthControl.Instance);
            } else if (tag == CollectionsControl.ID) {
                enablePanel(CollectionsControl.Instance);
            } else if (tag == FilesControl.ID) {
                enablePanel(FilesControl.Instance);
            } else if (tag == PoliciesControl.ID) {
                enablePanel(PoliciesControl.Instance);
            } else if (tag == UsersControl.ID) {
                enablePanel(UsersControl.Instance);
            }
        }

        private void enablePanel(UserControl control)
        {
            if (form.Controls.Contains(control)) {
                control.BringToFront();

                return;
            }

            form.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.BringToFront();
        }

        public string getLabel(string tag)
        {
            if (tag == AuthControl.ID) {
                return AuthControl.Label;
            } else if (tag == CollectionsControl.ID) {
                return CollectionsControl.Label;
            } else if (tag == FilesControl.ID) {
                return FilesControl.Label;
            } else if (tag == PoliciesControl.ID) {
                return PoliciesControl.Label;
            } else if (tag == UsersControl.ID) {
                return UsersControl.Label;
            } else {
                return "";
            }
        }
    }
}
