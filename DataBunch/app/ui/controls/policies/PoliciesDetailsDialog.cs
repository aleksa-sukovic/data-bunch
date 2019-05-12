using System;
using System.Windows.Forms;
using DataBunch.app.collection.models;
using DataBunch.app.collection.repositories;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.policies.models;
using DataBunch.app.policies.repositories;
using DataBunch.app.sessions.services;
using DataBunch.app.ui.services;
using DataBunch.app.user.models;
using DataBunch.app.user.repositories;

namespace DataBunch.app.ui.controls.policies
{
    public partial class PoliciesDetailsDialog : Form
    {
        private readonly DialogInterface dialogInterface;
        private readonly PolicyRepository repository;

        public PoliciesDetailsDialog(DialogInterface dialogInterface)
        {
            this.dialogInterface = dialogInterface;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            repository = new PolicyRepository();
            initializeCollectionsDropdown();
            initializeUsersDropdown();
        }

        private void onCancelClick(object sender, EventArgs e)
        {
            exitDialog();
        }

        private void onSaveClick(object sender, EventArgs e)
        {
            var collection = getSelectedCollection();
            var user = getSelectedUser();

            repository.grantToCollection(collection, user);

            exitDialog();
        }

        private void initializeCollectionsDropdown()
        {
            var items = new CollectionRepository().query().forUser(Auth.getUser()).get();

            if (items.Count < 1) {
                throw new ValidationException("You cannot create policy without existing collection.");
            }

            foreach (var i in items) {
                collectionsDropdown.AddItem(i.Name);
            }

            collectionsDropdown.selectedIndex = 0;
        }

        private void initializeUsersDropdown()
        {
            var items = new UserRepository().query()
                .where("id", "!=", Auth.getUser().ID).get();

            if (items.Count < 1) {
                throw new ValidationException("You are the only user of the system. Please add more users and restrict their access using policies.");
            }

            foreach (var i in items) {
                usersDropdown.AddItem(i.Name);
            }

            usersDropdown.selectedIndex = 0;
        }

        private Collection getSelectedCollection()
        {
            return new CollectionRepository().query()
                .where("name", "=", collectionsDropdown.selectedValue).first();
        }

        private User getSelectedUser()
        {
            return new UserRepository().query()
                .where("name", "=", usersDropdown.selectedValue).first();
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
