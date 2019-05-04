using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBunch.app.collection.repositories;
using DataBunch.app.foundation.db;
using DataBunch.app.foundation.utils;
using Microsoft.VisualBasic;

namespace DataBunch.app.ui.controls.collections
{
    public partial class CollectionsControl : UserControl
    {
        private static CollectionsControl instance;
        private const string id = "collections-control";
        private const string label = "Collections";
        private CollectionRepository collectionRepository;

        public static CollectionsControl Instance => instance ?? (instance = new CollectionsControl());
        public static string Label => label;
        public static string ID => id;

        private CollectionsControl()
        {
            InitializeComponent();

            loadData();

            foreach (ColumnHeader col in listView.Columns) {
                col.Width = -1;
            }
        }

        private void loadData()
        {
            listView.Items.Clear();
            collectionRepository = new CollectionRepository();
            var collections = collectionRepository.all(new List<QueryParam>());

            foreach (var collection in collections) {
                var item = new ListViewItem(collection.ID.ToString());

                foreach (var param in collection.ToArray()) {
                    item.SubItems.Add(param);
                }

                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        private void onEditButtonClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 1) {
                MessageBox.Show("Please select one item to edit.", "Check your actions");
                return;
            }

            Console.WriteLine("Edit => " + listView.SelectedItems[0].Text);
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

                Log.error("Delete => " + colId);
                collectionRepository.deleteById(colId);
            }

            loadData();
        }

        private void onMergeClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 2) {
                MessageBox.Show("Please select exactly 2 collections to merge.", "Check your actions");

                return;
            }

            var collectionName = Interaction.InputBox("Enter a name for new collection", "Merge two collections", "Merged Collection");
            var first = collectionRepository.one(long.Parse(listView.SelectedItems[0].Text));
            var second = collectionRepository.one(long.Parse(listView.SelectedItems[1].Text));

            collectionRepository.merge(first, second, collectionName);
            loadData();
        }

        private void onCreateButton(object sender, EventArgs e)
        {

        }
    }
}

