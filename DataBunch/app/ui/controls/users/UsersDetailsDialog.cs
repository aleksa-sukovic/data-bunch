using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;
using DataBunch.app.ui.services;
using DataBunch.app.user.models;
using DataBunch.app.user.repositories;

namespace DataBunch.app.ui.controls.users
{
    public partial class UsersDetailsDialog : Form
    {
        private User item;
        private readonly UserRepository repository;
        private readonly DialogInterface dialogInterface;

        public UsersDetailsDialog(User user, DialogInterface di)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            item = user;
            repository = new UserRepository();
            dialogInterface = di;

            initialize();
        }

        private void initialize()
        {
            initializeFields();
            initializePrivilegesDropdown();
            initializePasswordFields();
        }

        private void initializeFields()
        {
            usernameField.Text = item.Username;
            nameField.Text = item.Name;
            ageField.Text = item.Age.ToString();
        }

        private void initializePrivilegesDropdown()
        {
            privilegesDropdown.AddItem("User");
            privilegesDropdown.AddItem("Admin");

            privilegesDropdown.selectedIndex = item.Privilege == "admin" ? 1 : 0;
        }

        private void initializePasswordFields()
        {
            oldPasswordField.Visible = !item.isNull();
            oldPasswordLabel.Visible = !item.isNull();
        }

        private void onCancelClick(object sender, EventArgs e)
        {
            exitDialog();
        }

        private void onSaveClick(object sender, EventArgs e)
        {
            validateInput();

            item.Username = usernameField.Text;
            item.Name = nameField.Text;
            item.Age = int.Parse(ageField.Text);
            if (passwordField.Text.Length > 0 && Hash.make(passwordField.Text) != item.Password) {
                item.Password = passwordField.Text;
            }
            item.Privilege = privilegesDropdown.selectedValue.ToLower();
            item = repository.save(item);

            exitDialog();
        }

        private void validateInput()
        {
            if (usernameField.Text.Length < 3) {
                throw new ValidationException("Username must be at least 3 characters.");
            }

            if (string.IsNullOrEmpty(nameField.Text)) {
                throw new ValidationException("Please enter users name.");
            }

            if (!int.TryParse(ageField.Text, out var age)) {
                throw new ValidationException("Age must be a numeric value.");
            }

            if (item.isNull() && passwordField.Text.Length < 5) {
                throw new ValidationException("Password length must be at least 5 characters.");
            }

            if (passwordField.Text.Length > 0 && passwordField.Text != passwordConfirmationField.Text) {
                throw new ValidationException("Passwords do not match.");
            }

            if (!item.isNull() && passwordField.Text.Length > 0 && !Hash.check(item.Password, oldPasswordField.Text)) {
                throw new ValidationException("Old password is incorrect.");
            }
        }

        private void exitDialog()
        {
            dialogInterface?.onDialogClose();

            saveButton.Enabled = false;
            cancelButton.Enabled = false;

            Close();
        }
    }
}
