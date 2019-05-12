using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBunch.app.collection.repositories;
using DataBunch.app.file.models;
using DataBunch.app.file.repositories;
using DataBunch.app.foundation.db;
using DataBunch.app.sessions.services;
using DataBunch.app.ui.services;

namespace DataBunch.app.ui.controls.files
{
    public partial class FilesControl : UserControl, Refreshable, DialogInterface
    {
        private static FilesControl instance;
        private const string id = "files-control";
        private const string label = "Files";
        private readonly FileRepository repository;
        private List<File> filteredList;

        public static FilesControl Instance => instance ?? (instance = new FilesControl());
        public static string Label => label;
        public static string ID => id;

        private FilesControl()
        {
            repository = new FileRepository();
            filteredList = new List<File>();

            InitializeComponent();
            initializeCollectionsDropdown();

            refresh();
        }

        public void refresh()
        {
            listView.Items.Clear();

            var files = filteredList;
            if (files.Count <= 0) {
                files = repository.forUser(Auth.getUser());
            }

            foreach (var file in files) {
                var item = new ListViewItem(file.ID.ToString());

                foreach (var param in file.ToArray()) {
                    item.SubItems.Add(param);
                }

                listView.Items.Add(item);
            }

            resizeListView();
        }

        private void onEditButtonClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 1) {
                MessageBox.Show("Please select one item to edit.", "Check your actions");
                return;
            }

            var dialog = new FilesDetailsDialog(repository.one(long.Parse(listView.SelectedItems[0].Text)), this);

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
            var dialog = new FilesDetailsDialog(new File(), this);

            dialog.Show(this);
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

        private void initializeCollectionsDropdown()
        {
            var items = new CollectionRepository().query().forUser(Auth.getUser()).get();

            if (items.Count < 1) {
                collectionsDropdown.Visible = false;
            }

            foreach (var i in items) {
                collectionsDropdown.AddItem(i.Name);
            }

            collectionsDropdown.AddItem("Show all");
            collectionsDropdown.selectedIndex = items.Count;
        }

        private void onCollectionFilter(object sender, EventArgs e)
        {
            if (collectionsDropdown.selectedValue == "Show all") {
                filteredList.Clear();
                refresh();

                return;
            }

            var col = new CollectionRepository().query().where("name", "=", collectionsDropdown.selectedValue).first();

            filteredList = repository.query()
                .forUser(Auth.getUser())
                .where("collection_id", "=", col.ID)
                .get();

            refresh();
        }
    }
}

