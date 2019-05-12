namespace DataBunch.app.ui.controls.policies
{
    partial class PoliciesDetailsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoliciesDetailsDialog));
            this.label9 = new System.Windows.Forms.Label();
            this.collectionsDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.usersDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.cancelButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Collection";
            // 
            // collectionsDropdown
            // 
            this.collectionsDropdown.BackColor = System.Drawing.Color.Transparent;
            this.collectionsDropdown.BorderRadius = 3;
            this.collectionsDropdown.ForeColor = System.Drawing.Color.White;
            this.collectionsDropdown.Items = new string[0];
            this.collectionsDropdown.Location = new System.Drawing.Point(20, 115);
            this.collectionsDropdown.Name = "collectionsDropdown";
            this.collectionsDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.collectionsDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.collectionsDropdown.selectedIndex = -1;
            this.collectionsDropdown.Size = new System.Drawing.Size(217, 35);
            this.collectionsDropdown.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "User";
            // 
            // usersDropdown
            // 
            this.usersDropdown.BackColor = System.Drawing.Color.Transparent;
            this.usersDropdown.BorderRadius = 3;
            this.usersDropdown.ForeColor = System.Drawing.Color.White;
            this.usersDropdown.Items = new string[0];
            this.usersDropdown.Location = new System.Drawing.Point(20, 43);
            this.usersDropdown.Name = "usersDropdown";
            this.usersDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.usersDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.usersDropdown.selectedIndex = -1;
            this.usersDropdown.Size = new System.Drawing.Size(217, 35);
            this.usersDropdown.TabIndex = 18;
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
            this.cancelButton.Location = new System.Drawing.Point(129, 402);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.cancelButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.cancelButton.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelButton.selected = false;
            this.cancelButton.Size = new System.Drawing.Size(91, 38);
            this.cancelButton.TabIndex = 21;
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
            this.saveButton.Location = new System.Drawing.Point(30, 402);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(177)))), ((int)(((byte)(104)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(134)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(91, 38);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "         Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.onSaveClick);
            // 
            // PoliciesDetailsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 454);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersDropdown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.collectionsDropdown);
            this.MaximizeBox = false;
            this.Name = "PoliciesDetailsDialog";
            this.Text = "PoliciesDetailsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown collectionsDropdown;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown usersDropdown;
        private Bunifu.Framework.UI.BunifuFlatButton cancelButton;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
    }
}