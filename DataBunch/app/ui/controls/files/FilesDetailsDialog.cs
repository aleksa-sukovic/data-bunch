using System;
using System.Windows.Forms;
using DataBunch.app.collection.models;
using DataBunch.app.collection.repositories;
using DataBunch.app.file.models;
using DataBunch.app.file.repositories;
using DataBunch.app.foundation.exceptions;
using DataBunch.app.foundation.utils;
using DataBunch.app.ui.services;

namespace DataBunch.app.ui.controls.files
{
    public partial class FilesDetailsDialog : Form
    {
        private File item;
        private readonly FileRepository repository;
        private readonly CollectionRepository collectionRepository;
        private readonly DialogInterface dialogInterface;

        public FilesDetailsDialog(File editableItem, DialogInterface di = null)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            item = editableItem;
            repository = new FileRepository();
            collectionRepository = new CollectionRepository();
            dialogInterface = di;

            initialize();
        }

        private void initialize()
        {
            initializeFields();
            initializeCollectionsDropdown();
        }

        private void initializeFields()
        {
            nameField.Text = item.Name;
            pathField.Text = item.Path;
            typeField.Text = item.Type;
        }

        private void initializeCollectionsDropdown()
        {
            var items = new CollectionRepository().query().get();

            if (items.Count < 1) {
                throw new ValidationException("You cannot create files without existing collection.");
            }

            foreach (var i in items) {
                collectionsDropdown.AddItem(i.Name);
            }

            var index = -1;
            if (!item.isNull()) {
                index = items.FindIndex(i => i.Name == (item.Collection?.Name ?? ""));
            } else if (item.isNull() && items.Count > 0) {
                index = 0;
            }

            collectionsDropdown.selectedIndex = index;
        }

        private void onCancelClick(object sender, EventArgs e)
        {
            exitDialog();
        }

        private void onSaveClick(object sender, EventArgs e)
        {
            if (!validateInput()) {
                return;
            }

            var collection = getSelectedCollection();

            item.Name = nameField.Text;
            item.CollectionID = collection?.ID ?? 0;
            item = setItemPath(item, collection);
            item = repository.save(item);

            exitDialog();
        }

        private bool validateInput()
        {
            if (nameField.Text.Length < 1) {
                throw new ValidationException("Name field must contain at least 2 characters.");
            }

            if (pathField.Text.Length < 2) {
                throw new ValidationException("Please select path to a file.");
            }

            return true;
        }

        private File setItemPath(File file, Collection collection)
        {
            var oldPath = file.Path;
            var newPath = getFilePath(collection);
            file.Path = newPath;

            if (oldPath == newPath || collection?.Type == "no-files") {
                return file;
            }

            if (repository.getFileType(file) != collection?.Type) {
                exitDialog();

                throw new ValidationException("You can not move this file to collection of different type.");
            }

            Storage.copyFile(pathField.Text, newPath);
            Storage.deleteFile(oldPath);

            return file;
        }

        private string getFilePath(Collection collection)
        {
            var sourceFilePath = pathField.Text;

            // find filename from page (paths are separated using '/' or '\')
            var backSlashIndex = sourceFilePath.LastIndexOf("\\", StringComparison.Ordinal);
            var forwardSlashIndex = sourceFilePath.LastIndexOf("/", StringComparison.Ordinal);
            var index = backSlashIndex > forwardSlashIndex ? backSlashIndex : forwardSlashIndex;

            return collection?.Path + "/" + sourceFilePath.Substring(index + 1);
        }

        private void onPathBrowse(object sender, EventArgs e)
        {
            var extension = getSelectedCollection()?.Type ?? "*";

            if (extension == "no-files") {
                extension = "*";
            }

            var fileDialog = new OpenFileDialog {Filter = "File (*." + extension + ")|*." + extension};
            if (fileDialog.ShowDialog(this) == DialogResult.OK) {
                pathField.Text = fileDialog.FileName;
            }
        }

        private Collection getSelectedCollection()
        {
            return collectionRepository.query()
                .where("name", "=", collectionsDropdown.selectedValue).first(false);
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

