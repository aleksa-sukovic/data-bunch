using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBunch.app.collection.repositories;
using DataBunch.app.foundation.db;
using DataBunch.app.policies.repositories;
using DataBunch.app.ui.services;
using DataBunch.app.user.repositories;

namespace DataBunch.app.ui.controls.policies
{
    public partial class PoliciesControl : UserControl, Refreshable, DialogInterface
    {
        private static PoliciesControl instance;
        private const string id = "policies-control";
        private const string label = "Policies";
        private PolicyRepository repository;

        public static PoliciesControl Instance => instance ?? (instance = new PoliciesControl());
        public static string Label => label;
        public static string ID => id;
        public PoliciesControl()
        {
            repository = new PolicyRepository();

            InitializeComponent();

            refresh();
        }

        public void refresh()
        {
            listView.Items.Clear();
            var files = repository.all(new List<QueryParam>());

            foreach (var file in files) {
                var item = new ListViewItem(file.ID.ToString());

                foreach (var param in file.ToArray()) {
                    item.SubItems.Add(param);
                }

                listView.Items.Add(item);
            }

            resizeListView();
        }

        private void resizeListView()
        {
            foreach (ColumnHeader col in listView.Columns) {
                col.Width = listView.Items.Count > 0 ? -1 : -2;
            }
        }

        private void onCreateButton(object sender, EventArgs e)
        {
            var dialog = new PoliciesDetailsDialog(this);

            dialog.Show(this);
        }

        private void onDeleteButtonClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) {
                MessageBox.Show("Please select item(s) to delete.", "Check your actions");

                return;
            }

            if (MessageBox.Show("Are you sure you want to proceed ?", "Delete item(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                != DialogResult.Yes) {
                return;
            }

            var collectionRepo = new CollectionRepository();
            var userRepo = new UserRepository();

            for (var i = 0; i < listView.SelectedItems.Count; i++) {
                var isValid = long.TryParse(listView.SelectedItems[i].Text, out var colId);

                if (!isValid) {
                    continue;
                }

                var policy = repository.one(colId);
                repository.revokeFromCollection(collectionRepo.one(policy.TargetID), userRepo.one(policy.UserID));
            }

            refresh();
        }

        public void onDialogClose()
        {
            refresh();
        }
    }
}

