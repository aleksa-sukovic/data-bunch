using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DataBunch.app.collection.models;
using DataBunch.app.collection.repositories;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.sessions.services;
using DataBunch.app.ui.services;

namespace DataBunch.app.ui.controls.collections
{
    public partial class CollectionsDetailsDialog : Form
    {
        private Collection collection;
        private readonly CollectionRepository collectionRepository;
        private readonly DialogInterface dialogInterface;

        public CollectionsDetailsDialog(Collection collection, DialogInterface dialogInterface = null)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            collectionRepository = new CollectionRepository();
            this.collection = collectionRepository.addIncludes(collection);
            this.dialogInterface = dialogInterface;

            initialize();
        }

        private void initialize()
        {
            createFromDirCheckbox.Enabled = collection.isNull();
            createFromDirCheckbox.Checked = false;

            initializeDropdown();
            initializeFields();
        }

        private void initializeDropdown()
        {
            var items = collectionRepository.query()
                .where("id", "!=", collection.ID).withIncludes()
                .get();

            foreach (var item in items) {
                parentCollectionDropdown.AddItem(item.Name);
            }

            var index = -1;
            if (!collection.isNull()) {
                index = items.FindIndex(item => item.Name == collection.Parent?.Name);
            } else if (collection.isNull() && items.Count > 0) {
                index = 0;
            }

            parentCollectionDropdown.selectedIndex = index;
        }

        private void initializeFields()
        {
            nameField.Text = collection.Name;
            typeField.Text = collection.Type;
            pathField.Text = collection.Path;
            userField.Text = collection.User?.Name ?? Auth.getUser().Name;
            createdAtField.Text = collection.CreatedAt.ToShortDateString();
            updatedAtField.Text = collection.UpdatedAt.ToShortDateString();
            createFromDirCheckbox.Checked = true;
            createFromSourcePanel.Visible = collection.isNull();
        }

        private void onCancelClick(object sender, System.EventArgs e)
        {
            exitDialog();
        }

        private void onSaveClick(object sender, System.EventArgs e)
        {
            if (!validateInput()) {
                return;
            }

            if (createFromDirCheckbox.Checked && collection.isNull()) {
                createFromDirectory();
                exitDialog();
                return;
            }

            if (createFromZipCheckbox.Checked && collection.isNull()) {
                createFromZip();
                exitDialog();
                return;
            }

            collection.Name = nameField.Text;
            collection.UserID = Auth.getUser().ID;
            collection.Path = pathField.Text;
            collection.ParentID = parentCollectionDropdown.selectedIndex == -1 ? 0 : getSelectedParent();
            collection = collectionRepository.save(collection);

            exitDialog();
        }

        private bool validateInput()
        {
            if (nameField.Text.Length < 2) {
                throw new ValidationException("Name field must contain at least 2 characters.");
            }

            return true;
        }

        private void createFromDirectory()
        {
            collectionRepository.createFromDirectory(pathField.Text, nameField.Text, getSelectedParent());
        }

        private void createFromZip()
        {
            collectionRepository.createFromZip(pathField.Text, nameField.Text, getSelectedParent());
        }

        private int getSelectedParent()
        {
            var name = parentCollectionDropdown.selectedIndex != -1 ? parentCollectionDropdown.selectedValue : "";

            var item = collectionRepository.query()
                .where("name", "=", name)
                .first(false);

            return (int) (item?.ID ?? 0);
        }

        private void onPathBrowse(object sender, System.EventArgs e)
        {
            if (createFromDirCheckbox.Checked || !collection.isNull()) {
                showFolderDialog();

                return;
            }

            showFileDialog();
        }

        private void showFolderDialog()
        {
            var browserDialog = new FolderBrowserDialog();

            if (browserDialog.ShowDialog(this) == DialogResult.OK) {
                pathField.Text = browserDialog.SelectedPath;
            }
        }

        private void showFileDialog()
        {
            var fileDialog = new OpenFileDialog {Filter = "Zip files (*.zip)|*.zip"};

            if (fileDialog.ShowDialog(this) == DialogResult.OK){
                pathField.Text = fileDialog.FileName;
            }
        }

        private void onCreateSourceCheckChange(object sender, System.EventArgs e)
        {
            createFromDirCheckbox.Checked = false;
            createFromZipCheckbox.Checked = false;

            ((BunifuCheckbox) sender).Checked = true;
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

