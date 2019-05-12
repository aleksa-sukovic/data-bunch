using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;
using DataBunch.app.ui.controls.files;
using DataBunch.app.ui.services;
using DataBunch.app.user.models;
using DataBunch.app.user.repositories;

namespace DataBunch.app.ui.controls.users
{
    public partial class UsersControl : UserControl, Refreshable, DialogInterface
    {
        private static UsersControl instance;
        private const string id = "users-control";
        private const string label = "Users";
        private readonly UserRepository repository;

        public static UsersControl Instance => instance ?? (instance = new UsersControl());
        public static string Label => label;
        public static string ID => id;
        public UsersControl()
        {
            InitializeComponent();
            repository = new UserRepository();
            refresh();
        }

        public void refresh()
        {
            listView.Items.Clear();
            var users = repository.query().where("id", "!=", Auth.getUser().ID).get();

            foreach (var user in users) {
                var item = new ListViewItem(user.ID.ToString());

                foreach (var param in user.ToArray()) {
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

        public void onDialogClose()
        {
            refresh();
        }

        private void onEditButtonClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 1) {
                MessageBox.Show("Please select one item to edit.", "Check your actions");
                return;
            }

            var user = repository.one(long.Parse(listView.SelectedItems[0].Text));
            var dialog = new UsersDetailsDialog(user, this);

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

            for (var i = 0; i < listView.SelectedItems.Count; i++) {
                var isValid = long.TryParse(listView.SelectedItems[i].Text, out var colId);

                if (!isValid) {
                    continue;
                }

                repository.deleteById(colId);
            }

            refresh();
        }

        private void onCreateButton(object sender, EventArgs e)
        {
            var dialog = new UsersDetailsDialog(new User(), this);

            dialog.Show(this);
        }
    }
}

