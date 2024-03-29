using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBunch.app.foundation.models;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;
using DataBunch.app.ui.controls.users;
using DataBunch.app.ui.forms;
using DataBunch.app.ui.services;
using DataBunch.app.user.models;

namespace DataBunch.app.ui.controls.auth
{
    public partial class AuthControl : UserControl, Refreshable, DialogInterface
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
            refreshControls();
        }

        private void onLogIn(object sender, System.EventArgs e)
        {
            var username = usernameField.Text;
            var password = passwordField.Text;

            Auth.logIn(username, password);
            refreshControls();
            passwordField.ResetText();

            if (Parent is WelcomeForm form) {
                form.initializeForm();
            }
        }

        private void refreshControls()
        {
            if (Auth.isLoggedIn()) {
                profilePanel.Visible = true;
                profilePanel.BringToFront();
                logInPanel.Visible = false;
                updateProfileControls();
            } else {
                logInPanel.BringToFront();
                logInPanel.Visible = true;
                profilePanel.Visible = false;
            }
        }

        private void onLogOut(object sender, EventArgs e)
        {
            Auth.logOut();
            refreshControls();

            if (Parent is WelcomeForm form) {
                form.initializeForm();
            }
        }

        private void updateProfileControls()
        {
            var user = Auth.getUser();

            profileUsernameField.Text = user.Username;
            profileFullNameField.Text = user.Name;
            profileAgeField.Text = user.Age.ToString();
            profilePrivilegeField.Text = user.Privilege;
        }

        public void refresh()
        {
            refreshControls();
        }

        private void onEditProfile(object sender, EventArgs e)
        {
            var dialog = new UsersDetailsDialog(Auth.getUser(), this);

            dialog.Show(this);
        }

        public void onDialogClose()
        {
            refresh();
        }
    }
}

