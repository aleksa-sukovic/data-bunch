using System.ComponentModel;

namespace DataBunch.app.ui.controls.auth
{
    partial class AuthControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthControl));
            this.logInPanel = new System.Windows.Forms.Panel();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.passwordField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usernameField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.profileUsernameField = new System.Windows.Forms.Label();
            this.profilePrivilegeField = new System.Windows.Forms.Label();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.profileFullNameField = new System.Windows.Forms.Label();
            this.profileAgeField = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logInPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInPanel
            // 
            this.logInPanel.BackColor = System.Drawing.SystemColors.Control;
            this.logInPanel.Controls.Add(this.loginButton);
            this.logInPanel.Controls.Add(this.bunifuCustomLabel2);
            this.logInPanel.Controls.Add(this.passwordField);
            this.logInPanel.Controls.Add(this.bunifuCustomLabel1);
            this.logInPanel.Controls.Add(this.usernameField);
            this.logInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInPanel.Location = new System.Drawing.Point(5, 0);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(685, 514);
            this.logInPanel.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "                                 Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = false;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(224, 339);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(241, 40);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "                                 Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.onLogIn);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(151, 250);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(59, 17);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.passwordField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.passwordField.BorderThickness = 2;
            this.passwordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passwordField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.passwordField.isPassword = true;
            this.passwordField.Location = new System.Drawing.Point(154, 271);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(370, 44);
            this.passwordField.TabIndex = 6;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(151, 174);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(65, 17);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.White;
            this.usernameField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.usernameField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.usernameField.BorderThickness = 2;
            this.usernameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usernameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.usernameField.isPassword = false;
            this.usernameField.Location = new System.Drawing.Point(154, 195);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(370, 44);
            this.usernameField.TabIndex = 4;
            this.usernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // profilePanel
            // 
            this.profilePanel.AutoSize = true;
            this.profilePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilePanel.Controls.Add(this.bunifuCustomLabel3);
            this.profilePanel.Controls.Add(this.profileUsernameField);
            this.profilePanel.Controls.Add(this.profilePrivilegeField);
            this.profilePanel.Controls.Add(this.bunifuCustomLabel4);
            this.profilePanel.Controls.Add(this.bunifuCustomLabel7);
            this.profilePanel.Controls.Add(this.profileFullNameField);
            this.profilePanel.Controls.Add(this.profileAgeField);
            this.profilePanel.Controls.Add(this.bunifuCustomLabel6);
            this.profilePanel.Controls.Add(this.logoutButton);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePanel.Location = new System.Drawing.Point(5, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(685, 514);
            this.profilePanel.TabIndex = 9;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(229, 150);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(20);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(83, 21);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Username";
            // 
            // profileUsernameField
            // 
            this.profileUsernameField.AutoSize = true;
            this.profileUsernameField.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileUsernameField.Location = new System.Drawing.Point(335, 154);
            this.profileUsernameField.Name = "profileUsernameField";
            this.profileUsernameField.Size = new System.Drawing.Size(91, 17);
            this.profileUsernameField.TabIndex = 12;
            this.profileUsernameField.Text = "aleksa-sukovic";
            // 
            // profilePrivilegeField
            // 
            this.profilePrivilegeField.AutoSize = true;
            this.profilePrivilegeField.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePrivilegeField.Location = new System.Drawing.Point(335, 337);
            this.profilePrivilegeField.Name = "profilePrivilegeField";
            this.profilePrivilegeField.Size = new System.Drawing.Size(44, 17);
            this.profilePrivilegeField.TabIndex = 18;
            this.profilePrivilegeField.Text = "admin";
            this.profilePrivilegeField.UseMnemonic = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(229, 211);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(20);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Full Name";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(229, 333);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(20);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(73, 21);
            this.bunifuCustomLabel7.TabIndex = 17;
            this.bunifuCustomLabel7.Text = "Privilege";
            // 
            // profileFullNameField
            // 
            this.profileFullNameField.AutoSize = true;
            this.profileFullNameField.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileFullNameField.Location = new System.Drawing.Point(333, 215);
            this.profileFullNameField.Name = "profileFullNameField";
            this.profileFullNameField.Size = new System.Drawing.Size(92, 17);
            this.profileFullNameField.TabIndex = 14;
            this.profileFullNameField.Text = "Aleksa Sukovic";
            // 
            // profileAgeField
            // 
            this.profileAgeField.AutoSize = true;
            this.profileAgeField.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileAgeField.Location = new System.Drawing.Point(333, 275);
            this.profileAgeField.Name = "profileAgeField";
            this.profileAgeField.Size = new System.Drawing.Size(22, 17);
            this.profileAgeField.TabIndex = 16;
            this.profileAgeField.Text = "22";
            this.profileAgeField.UseMnemonic = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(229, 272);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(20);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(40, 21);
            this.bunifuCustomLabel6.TabIndex = 15;
            this.bunifuCustomLabel6.Text = "Age";
            // 
            // logoutButton
            // 
            this.logoutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.BorderRadius = 0;
            this.logoutButton.ButtonText = "            Logout";
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.logoutButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutButton.Iconimage")));
            this.logoutButton.Iconimage_right = null;
            this.logoutButton.Iconimage_right_Selected = null;
            this.logoutButton.Iconimage_Selected = null;
            this.logoutButton.IconMarginLeft = 0;
            this.logoutButton.IconMarginRight = 0;
            this.logoutButton.IconRightVisible = true;
            this.logoutButton.IconRightZoom = 0D;
            this.logoutButton.IconVisible = false;
            this.logoutButton.IconZoom = 90D;
            this.logoutButton.IsTab = false;
            this.logoutButton.Location = new System.Drawing.Point(546, 465);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(20);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.logoutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutButton.selected = false;
            this.logoutButton.Size = new System.Drawing.Size(119, 29);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "            Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Textcolor = System.Drawing.Color.White;
            this.logoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Click += new System.EventHandler(this.onLogOut);
            // 
            // AuthControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.logInPanel);
            this.Name = "AuthControl";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Size = new System.Drawing.Size(690, 514);
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel logInPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordField;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernameField;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private System.Windows.Forms.Panel profilePanel;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label profileUsernameField;
        private System.Windows.Forms.Label profilePrivilegeField;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Label profileFullNameField;
        private System.Windows.Forms.Label profileAgeField;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
    }
}

