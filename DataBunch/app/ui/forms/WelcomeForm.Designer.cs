namespace DataBunch.app.ui.forms
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.sidebar = new System.Windows.Forms.Panel();
            this.usersPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.policiesPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.filesPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.collectionsPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.authPanelButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.minimiseButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerTitle = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.sidebar.Controls.Add(this.usersPanel);
            this.sidebar.Controls.Add(this.policiesPanel);
            this.sidebar.Controls.Add(this.filesPanel);
            this.sidebar.Controls.Add(this.collectionsPanel);
            this.sidebar.Controls.Add(this.authPanelButton);
            this.sidebar.Controls.Add(this.logoPanel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(190, 458);
            this.sidebar.TabIndex = 0;
            // 
            // usersPanel
            // 
            this.usersPanel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.usersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.usersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usersPanel.BorderRadius = 0;
            this.usersPanel.ButtonText = "             Users";
            this.usersPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersPanel.DisabledColor = System.Drawing.Color.Gray;
            this.usersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.usersPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("usersPanel.Iconimage")));
            this.usersPanel.Iconimage_right = null;
            this.usersPanel.Iconimage_right_Selected = null;
            this.usersPanel.Iconimage_Selected = null;
            this.usersPanel.IconMarginLeft = 0;
            this.usersPanel.IconMarginRight = 0;
            this.usersPanel.IconRightVisible = true;
            this.usersPanel.IconRightZoom = 0D;
            this.usersPanel.IconVisible = false;
            this.usersPanel.IconZoom = 90D;
            this.usersPanel.IsTab = false;
            this.usersPanel.Location = new System.Drawing.Point(0, 267);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.usersPanel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.usersPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.usersPanel.selected = false;
            this.usersPanel.Size = new System.Drawing.Size(190, 48);
            this.usersPanel.TabIndex = 7;
            this.usersPanel.Text = "             Users";
            this.usersPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersPanel.Textcolor = System.Drawing.Color.White;
            this.usersPanel.TextFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // policiesPanel
            // 
            this.policiesPanel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.policiesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.policiesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.policiesPanel.BorderRadius = 0;
            this.policiesPanel.ButtonText = "            Policies";
            this.policiesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.policiesPanel.DisabledColor = System.Drawing.Color.Gray;
            this.policiesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.policiesPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.policiesPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("policiesPanel.Iconimage")));
            this.policiesPanel.Iconimage_right = null;
            this.policiesPanel.Iconimage_right_Selected = null;
            this.policiesPanel.Iconimage_Selected = null;
            this.policiesPanel.IconMarginLeft = 0;
            this.policiesPanel.IconMarginRight = 0;
            this.policiesPanel.IconRightVisible = true;
            this.policiesPanel.IconRightZoom = 0D;
            this.policiesPanel.IconVisible = false;
            this.policiesPanel.IconZoom = 90D;
            this.policiesPanel.IsTab = false;
            this.policiesPanel.Location = new System.Drawing.Point(0, 219);
            this.policiesPanel.Name = "policiesPanel";
            this.policiesPanel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.policiesPanel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.policiesPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.policiesPanel.selected = false;
            this.policiesPanel.Size = new System.Drawing.Size(190, 48);
            this.policiesPanel.TabIndex = 6;
            this.policiesPanel.Text = "            Policies";
            this.policiesPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.policiesPanel.Textcolor = System.Drawing.Color.White;
            this.policiesPanel.TextFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // filesPanel
            // 
            this.filesPanel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.filesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.filesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filesPanel.BorderRadius = 0;
            this.filesPanel.ButtonText = "              Files";
            this.filesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filesPanel.DisabledColor = System.Drawing.Color.Gray;
            this.filesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filesPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.filesPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("filesPanel.Iconimage")));
            this.filesPanel.Iconimage_right = null;
            this.filesPanel.Iconimage_right_Selected = null;
            this.filesPanel.Iconimage_Selected = null;
            this.filesPanel.IconMarginLeft = 0;
            this.filesPanel.IconMarginRight = 0;
            this.filesPanel.IconRightVisible = true;
            this.filesPanel.IconRightZoom = 0D;
            this.filesPanel.IconVisible = false;
            this.filesPanel.IconZoom = 90D;
            this.filesPanel.IsTab = false;
            this.filesPanel.Location = new System.Drawing.Point(0, 171);
            this.filesPanel.Name = "filesPanel";
            this.filesPanel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.filesPanel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.filesPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.filesPanel.selected = false;
            this.filesPanel.Size = new System.Drawing.Size(190, 48);
            this.filesPanel.TabIndex = 5;
            this.filesPanel.Text = "              Files";
            this.filesPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filesPanel.Textcolor = System.Drawing.Color.White;
            this.filesPanel.TextFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // collectionsPanel
            // 
            this.collectionsPanel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.collectionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.collectionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.collectionsPanel.BorderRadius = 0;
            this.collectionsPanel.ButtonText = "          Collections";
            this.collectionsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collectionsPanel.DisabledColor = System.Drawing.Color.Gray;
            this.collectionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.collectionsPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.collectionsPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("collectionsPanel.Iconimage")));
            this.collectionsPanel.Iconimage_right = null;
            this.collectionsPanel.Iconimage_right_Selected = null;
            this.collectionsPanel.Iconimage_Selected = null;
            this.collectionsPanel.IconMarginLeft = 0;
            this.collectionsPanel.IconMarginRight = 0;
            this.collectionsPanel.IconRightVisible = true;
            this.collectionsPanel.IconRightZoom = 0D;
            this.collectionsPanel.IconVisible = false;
            this.collectionsPanel.IconZoom = 90D;
            this.collectionsPanel.IsTab = false;
            this.collectionsPanel.Location = new System.Drawing.Point(0, 123);
            this.collectionsPanel.Name = "collectionsPanel";
            this.collectionsPanel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.collectionsPanel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.collectionsPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.collectionsPanel.selected = false;
            this.collectionsPanel.Size = new System.Drawing.Size(190, 48);
            this.collectionsPanel.TabIndex = 4;
            this.collectionsPanel.Text = "          Collections";
            this.collectionsPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.collectionsPanel.Textcolor = System.Drawing.Color.White;
            this.collectionsPanel.TextFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // authPanelButton
            // 
            this.authPanelButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.authPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.authPanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.authPanelButton.BorderRadius = 0;
            this.authPanelButton.ButtonText = "              Auth";
            this.authPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authPanelButton.DisabledColor = System.Drawing.Color.Gray;
            this.authPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.authPanelButton.Iconcolor = System.Drawing.Color.Transparent;
            this.authPanelButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("authPanelButton.Iconimage")));
            this.authPanelButton.Iconimage_right = null;
            this.authPanelButton.Iconimage_right_Selected = null;
            this.authPanelButton.Iconimage_Selected = null;
            this.authPanelButton.IconMarginLeft = 0;
            this.authPanelButton.IconMarginRight = 0;
            this.authPanelButton.IconRightVisible = true;
            this.authPanelButton.IconRightZoom = 0D;
            this.authPanelButton.IconVisible = false;
            this.authPanelButton.IconZoom = 90D;
            this.authPanelButton.IsTab = false;
            this.authPanelButton.Location = new System.Drawing.Point(0, 75);
            this.authPanelButton.Name = "authPanelButton";
            this.authPanelButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.authPanelButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.authPanelButton.OnHoverTextColor = System.Drawing.Color.White;
            this.authPanelButton.selected = false;
            this.authPanelButton.Size = new System.Drawing.Size(190, 48);
            this.authPanelButton.TabIndex = 3;
            this.authPanelButton.Text = "              Auth";
            this.authPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authPanelButton.Textcolor = System.Drawing.Color.White;
            this.authPanelButton.TextFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(190, 75);
            this.logoPanel.TabIndex = 2;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Bunch";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.minimiseButton);
            this.header.Controls.Add(this.closeButton);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.headerTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(190, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(551, 75);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            // 
            // minimiseButton
            // 
            this.minimiseButton.AutoSize = true;
            this.minimiseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiseButton.Location = new System.Drawing.Point(502, 9);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(14, 20);
            this.minimiseButton.TabIndex = 4;
            this.minimiseButton.Text = "-";
            this.minimiseButton.Click += new System.EventHandler(this.onMinimiseClick);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(522, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.onExitClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::DataBunch.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(16, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // headerTitle
            // 
            this.headerTitle.AutoSize = true;
            this.headerTitle.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitle.Location = new System.Drawing.Point(44, 23);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(135, 28);
            this.headerTitle.TabIndex = 1;
            this.headerTitle.Text = "Authentication";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(741, 458);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.onLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.sidebar.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton authPanelButton;
        private Bunifu.Framework.UI.BunifuFlatButton filesPanel;
        private Bunifu.Framework.UI.BunifuFlatButton collectionsPanel;
        private Bunifu.Framework.UI.BunifuFlatButton usersPanel;
        private Bunifu.Framework.UI.BunifuFlatButton policiesPanel;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label minimiseButton;
        private System.Windows.Forms.Label closeButton;
    }
}
