using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;

namespace DataBunch.app.ui.forms
{
    public partial class WelcomeForm : Form
    {
        private Point lastPoint;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            ConsoleManager.Show();
            Auth.init();

            initializeForm();
        }

        private void initializeForm()
        {
            if (!Auth.isLoggedIn()) {
                initializeNotLoggedIn();

                return;
            }

            initializeLoggedIn();
        }

        private void initializeNotLoggedIn()
        {
            collectionsPanelButton.Visible = false;
            filesPanelButton.Visible = false;
            policiesPanelButton.Visible = false;
            usersPanelButton.Visible = false;

            authPanelButton.selected = true;
            headerTitle.Text = authPanelButton.Text.Trim();
            navigateToPanel("Auth");
        }

        private void initializeLoggedIn()
        {
            collectionsPanelButton.selected = true;
            headerTitle.Text = collectionsPanelButton.Text.Trim();

            navigateToPanel("Collections");
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

        private void switchPanel(object sender, EventArgs e)
        {
            toggleButtons(sender);

            var button = (BunifuFlatButton) sender;

            headerTitle.Text = button.Text.Trim();
            navigateToPanel(button.Text);
        }

        private void toggleButtons(object sender)
        {
            authPanelButton.selected = false;
            collectionsPanelButton.selected = false;
            filesPanelButton.selected = false;
            policiesPanelButton.selected = false;
            usersPanelButton.selected = false;

            ((BunifuFlatButton)sender).selected = true;
        }

        private void navigateToPanel(object panel)
        {
            Log.debug("Navigate to panel => " + panel.ToString().Trim());
        }
    }
}
