using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;
using DataBunch.app.ui.controls.auth;
using DataBunch.app.ui.controls.collections;
using DataBunch.app.ui.controls.files;
using DataBunch.app.ui.controls.policies;
using DataBunch.app.ui.controls.users;
using DataBunch.app.ui.services;

namespace DataBunch.app.ui.forms
{
    public partial class WelcomeForm : Form, SidebarButtons.FormWithSidebar
    {
        private Point lastPoint;
        private readonly ControlSwitcher controlSwitcher;
        private readonly SidebarButtons sidebarButtons;

        public WelcomeForm()
        {
            InitializeComponent();
            controlSwitcher = new ControlSwitcher(this);
            sidebarButtons = new SidebarButtons(new List<BunifuFlatButton> {
                authPanelButton, collectionsPanelButton, filesPanelButton, policiesPanelButton, usersPanelButton
            }, this);
        }

        private void onLoad(object sender, EventArgs e)
        {
            ConsoleManager.Show();
            Auth.init();

            initializeButtons();
            initializeForm();

            if (Auth.isLoggedIn()) {
                navigateToPanel(CollectionsControl.ID);
            }
        }

        private void initializeButtons()
        {
            authPanelButton.Tag = AuthControl.ID;
            collectionsPanelButton.Tag = CollectionsControl.ID;
            filesPanelButton.Tag = FilesControl.ID;
            policiesPanelButton.Tag = PoliciesControl.ID;
            usersPanelButton.Tag = UsersControl.ID;
        }

        public void initializeForm()
        {
            if (!Auth.isLoggedIn()) {
                sidebarButtons.hideAll();
                sidebarButtons.show(AuthControl.ID);

                return;
            }

            sidebarButtons.showAll();
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void onMinimiseClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void onExitClick(object sender, EventArgs e)
        {
            Close();
        }

        public void onSidebarButtonClick(string tag)
        {
            navigateToPanel(tag);
        }

        private void navigateToPanel(string tag)
        {
            sidebarButtons.turnOn(tag);
            controlSwitcher.switchToPanel(tag);
            headerTitle.Text = controlSwitcher.getLabel(tag);
        }
    }
}
