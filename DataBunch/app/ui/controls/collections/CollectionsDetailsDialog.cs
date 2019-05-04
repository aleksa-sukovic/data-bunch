using System.Windows.Forms;
using DataBunch.app.collection.models;
using DataBunch.app.collection.repositories;
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
            this.collection = collection;
            collectionRepository = new CollectionRepository();
            this.dialogInterface = dialogInterface;

            initialize();
        }

        private void initialize()
        {
            createFromSourceCheckbox.Enabled = collection.isNull();
            createFromSourceCheckbox.Checked = false;

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

            var index = 0;
            if (!collection.isNull() && collection.ParentID == 0) {
                index = -1;
            } else if (!collection.isNull()) {
                index = items.FindIndex(item => item.Name == collection.Parent.Name);
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
        }

        private void onCancelClick(object sender, System.EventArgs e)
        {
            dialogInterface?.onDialogClose();

            Close();
        }

        private void onSaveClick(object sender, System.EventArgs e)
        {
            collection.Name = nameField.Text;
            collection.UserID = Auth.getUser().ID;
            collection.Path = pathField.Text;
            collection.ParentID = parentCollectionDropdown.selectedIndex == -1 ? 0 : getSelectedParent();
            collection = collectionRepository.save(collection);

            dialogInterface?.onDialogClose();
            Close();
        }

        private int getSelectedParent()
        {
            var item = collectionRepository.query()
                .where("name", "=", parentCollectionDropdown.selectedValue)
                .first(false);

            return (int) (item?.ID ?? 0);
        }

    }
}

