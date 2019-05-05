using System.ComponentModel;

namespace DataBunch.app.ui.controls.collections
{
    partial class CollectionsDetailsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionsDetailsDialog));
            this.createCollectionsPanel = new System.Windows.Forms.Panel();
            this.createFromSourcePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.createFromDirCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.parentCollectionDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.updatedAtField = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.createdAtField = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeField = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.createFromZipCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.createCollectionsPanel.SuspendLayout();
            this.createFromSourcePanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCollectionsPanel
            // 
            this.createCollectionsPanel.Controls.Add(this.bunifuFlatButton3);
            this.createCollectionsPanel.Controls.Add(this.createFromSourcePanel);
            this.createCollectionsPanel.Controls.Add(this.label3);
            this.createCollectionsPanel.Controls.Add(this.pathField);
            this.createCollectionsPanel.Controls.Add(this.cancelButton);
            this.createCollectionsPanel.Controls.Add(this.saveButton);
            this.createCollectionsPanel.Controls.Add(this.label9);
            this.createCollectionsPanel.Controls.Add(this.parentCollectionDropdown);
            this.createCollectionsPanel.Controls.Add(this.detailsPanel);
            this.createCollectionsPanel.Controls.Add(this.label1);
            this.createCollectionsPanel.Controls.Add(this.nameField);
            this.createCollectionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createCollectionsPanel.Location = new System.Drawing.Point(0, 0);
            this.createCollectionsPanel.Name = "createCollectionsPanel";
            this.createCollectionsPanel.Size = new System.Drawing.Size(249, 554);
            this.createCollectionsPanel.TabIndex = 0;
            // 
            // createFromSourcePanel
            // 
            this.createFromSourcePanel.Controls.Add(this.label7);
            this.createFromSourcePanel.Controls.Add(this.createFromZipCheckbox);
            this.createFromSourcePanel.Controls.Add(this.label5);
            this.createFromSourcePanel.Controls.Add(this.createFromDirCheckbox);
            this.createFromSourcePanel.Location = new System.Drawing.Point(16, 162);
            this.createFromSourcePanel.Name = "createFromSourcePanel";
            this.createFromSourcePanel.Size = new System.Drawing.Size(215, 53);
            this.createFromSourcePanel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Create from directory";
            // 
            // createFromDirCheckbox
            // 
            this.createFromDirCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.createFromDirCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.createFromDirCheckbox.Checked = true;
            this.createFromDirCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.createFromDirCheckbox.ForeColor = System.Drawing.Color.White;
            this.createFromDirCheckbox.Location = new System.Drawing.Point(195, 0);
            this.createFromDirCheckbox.Name = "createFromDirCheckbox";
            this.createFromDirCheckbox.Size = new System.Drawing.Size(20, 20);
            this.createFromDirCheckbox.TabIndex = 11;
            this.createFromDirCheckbox.OnChange += new System.EventHandler(this.onCreateSourceCheckChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path";
            // 
            // pathField
            // 
            this.pathField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.pathField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.pathField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.pathField.BorderThickness = 2;
            this.pathField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pathField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pathField.isPassword = false;
            this.pathField.Location = new System.Drawing.Point(16, 117);
            this.pathField.Margin = new System.Windows.Forms.Padding(4);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(176, 34);
            this.pathField.TabIndex = 7;
            this.pathField.Text = "Collection Path";
            this.pathField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Parent";
            // 
            // parentCollectionDropdown
            // 
            this.parentCollectionDropdown.BackColor = System.Drawing.Color.Transparent;
            this.parentCollectionDropdown.BorderRadius = 3;
            this.parentCollectionDropdown.ForeColor = System.Drawing.Color.White;
            this.parentCollectionDropdown.Items = new string[0];
            this.parentCollectionDropdown.Location = new System.Drawing.Point(17, 256);
            this.parentCollectionDropdown.Name = "parentCollectionDropdown";
            this.parentCollectionDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.parentCollectionDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.parentCollectionDropdown.selectedIndex = -1;
            this.parentCollectionDropdown.Size = new System.Drawing.Size(217, 35);
            this.parentCollectionDropdown.TabIndex = 3;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.updatedAtField);
            this.detailsPanel.Controls.Add(this.label8);
            this.detailsPanel.Controls.Add(this.createdAtField);
            this.detailsPanel.Controls.Add(this.label6);
            this.detailsPanel.Controls.Add(this.userField);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.typeField);
            this.detailsPanel.Controls.Add(this.label2);
            this.detailsPanel.Location = new System.Drawing.Point(15, 310);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(219, 176);
            this.detailsPanel.TabIndex = 2;
            // 
            // updatedAtField
            // 
            this.updatedAtField.AutoSize = true;
            this.updatedAtField.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedAtField.Location = new System.Drawing.Point(125, 137);
            this.updatedAtField.Name = "updatedAtField";
            this.updatedAtField.Size = new System.Drawing.Size(68, 17);
            this.updatedAtField.TabIndex = 9;
            this.updatedAtField.Text = "05.05.2019";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Updated At:";
            // 
            // createdAtField
            // 
            this.createdAtField.AutoSize = true;
            this.createdAtField.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdAtField.Location = new System.Drawing.Point(126, 95);
            this.createdAtField.Name = "createdAtField";
            this.createdAtField.Size = new System.Drawing.Size(68, 17);
            this.createdAtField.TabIndex = 7;
            this.createdAtField.Text = "04.05.2019";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Created At:";
            // 
            // userField
            // 
            this.userField.AutoSize = true;
            this.userField.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(125, 54);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(90, 17);
            this.userField.TabIndex = 5;
            this.userField.Text = "Aleksa Sukovic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "User:";
            // 
            // typeField
            // 
            this.typeField.AutoSize = true;
            this.typeField.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeField.Location = new System.Drawing.Point(125, 13);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(26, 17);
            this.typeField.TabIndex = 3;
            this.typeField.Text = "pdf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameField
            // 
            this.nameField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.nameField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.nameField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.nameField.BorderThickness = 2;
            this.nameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameField.isPassword = false;
            this.nameField.Location = new System.Drawing.Point(18, 44);
            this.nameField.Margin = new System.Windows.Forms.Padding(4);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(212, 34);
            this.nameField.TabIndex = 0;
            this.nameField.Text = "Collection Name";
            this.nameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Create from zip";
            // 
            // createFromZipCheckbox
            // 
            this.createFromZipCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.createFromZipCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.createFromZipCheckbox.Checked = false;
            this.createFromZipCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.createFromZipCheckbox.ForeColor = System.Drawing.Color.White;
            this.createFromZipCheckbox.Location = new System.Drawing.Point(195, 30);
            this.createFromZipCheckbox.Name = "createFromZipCheckbox";
            this.createFromZipCheckbox.Size = new System.Drawing.Size(20, 20);
            this.createFromZipCheckbox.TabIndex = 13;
            this.createFromZipCheckbox.OnChange += new System.EventHandler(this.onCreateSourceCheckChange);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::DataBunch.Properties.Resources.search;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(199, 118);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(32, 32);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.onPathBrowse);
            // 
            // cancelButton
            // 
            this.cancelButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.BorderRadius = 0;
            this.cancelButton.ButtonText = "       Cancel";
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DisabledColor = System.Drawing.Color.Gray;
            this.cancelButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancelButton.Iconimage")));
            this.cancelButton.Iconimage_right = null;
            this.cancelButton.Iconimage_right_Selected = null;
            this.cancelButton.Iconimage_Selected = null;
            this.cancelButton.IconMarginLeft = 0;
            this.cancelButton.IconMarginRight = 0;
            this.cancelButton.IconRightVisible = true;
            this.cancelButton.IconRightZoom = 0D;
            this.cancelButton.IconVisible = false;
            this.cancelButton.IconZoom = 90D;
            this.cancelButton.IsTab = false;
            this.cancelButton.Location = new System.Drawing.Point(126, 499);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.cancelButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.cancelButton.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelButton.selected = false;
            this.cancelButton.Size = new System.Drawing.Size(91, 38);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "       Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Textcolor = System.Drawing.Color.White;
            this.cancelButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Click += new System.EventHandler(this.onCancelClick);
            // 
            // saveButton
            // 
            this.saveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 0;
            this.saveButton.ButtonText = "         Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveButton.Iconimage")));
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = true;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = false;
            this.saveButton.IconZoom = 90D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(27, 499);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(134)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(91, 38);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "         Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.onSaveClick);
            // 
            // CollectionsDetailsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 554);
            this.Controls.Add(this.createCollectionsPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollectionsDetailsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Collection Details";
            this.createCollectionsPanel.ResumeLayout(false);
            this.createCollectionsPanel.PerformLayout();
            this.createFromSourcePanel.ResumeLayout(false);
            this.createFromSourcePanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel createCollectionsPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameField;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label typeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label updatedAtField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label createdAtField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label userField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown parentCollectionDropdown;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
        private Bunifu.Framework.UI.BunifuFlatButton cancelButton;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox pathField;
        private System.Windows.Forms.Panel createFromSourcePanel;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox createFromDirCheckbox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCheckbox createFromZipCheckbox;
    }
}

