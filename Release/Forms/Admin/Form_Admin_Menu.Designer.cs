namespace e_Projects.Forms
{
    partial class Form_Admin_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Menu));
            this.panel_Menu_Header = new System.Windows.Forms.Panel();
            this.pictureBox_Admin_Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox_User_Profile = new System.Windows.Forms.PictureBox();
            this.button_User_Dropdown = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.imageList_BigButtons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Container = new System.Windows.Forms.Panel();
            this.button_Show_Assignments = new System.Windows.Forms.Button();
            this.button_Show_Team = new System.Windows.Forms.Button();
            this.button_Show_Users = new System.Windows.Forms.Button();
            this.panel_User_Dropdown = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.panel_Menu_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Profile)).BeginInit();
            this.panel_Container.SuspendLayout();
            this.panel_User_Dropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu_Header
            // 
            this.panel_Menu_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.panel_Menu_Header.Controls.Add(this.pictureBox_Admin_Icon);
            this.panel_Menu_Header.Controls.Add(this.pictureBox_User_Profile);
            this.panel_Menu_Header.Controls.Add(this.button_User_Dropdown);
            this.panel_Menu_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu_Header.Name = "panel_Menu_Header";
            this.panel_Menu_Header.Size = new System.Drawing.Size(455, 85);
            this.panel_Menu_Header.TabIndex = 5;
            // 
            // pictureBox_Admin_Icon
            // 
            this.pictureBox_Admin_Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Admin_Icon.Image = global::e_Projects.Properties.Resources.admin_icon;
            this.pictureBox_Admin_Icon.Location = new System.Drawing.Point(177, 24);
            this.pictureBox_Admin_Icon.Name = "pictureBox_Admin_Icon";
            this.pictureBox_Admin_Icon.Size = new System.Drawing.Size(40, 35);
            this.pictureBox_Admin_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Admin_Icon.TabIndex = 8;
            this.pictureBox_Admin_Icon.TabStop = false;
            // 
            // pictureBox_User_Profile
            // 
            this.pictureBox_User_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_User_Profile.Image = global::e_Projects.Properties.Resources.user;
            this.pictureBox_User_Profile.Location = new System.Drawing.Point(218, 18);
            this.pictureBox_User_Profile.Name = "pictureBox_User_Profile";
            this.pictureBox_User_Profile.Size = new System.Drawing.Size(51, 46);
            this.pictureBox_User_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_User_Profile.TabIndex = 6;
            this.pictureBox_User_Profile.TabStop = false;
            // 
            // button_User_Dropdown
            // 
            this.button_User_Dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_User_Dropdown.BackColor = System.Drawing.Color.Transparent;
            this.button_User_Dropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_User_Dropdown.FlatAppearance.BorderSize = 0;
            this.button_User_Dropdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_User_Dropdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_User_Dropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_User_Dropdown.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_User_Dropdown.ForeColor = System.Drawing.Color.White;
            this.button_User_Dropdown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_User_Dropdown.ImageKey = "dropdown-inactive.png";
            this.button_User_Dropdown.ImageList = this.imageList_Buttons;
            this.button_User_Dropdown.Location = new System.Drawing.Point(243, 24);
            this.button_User_Dropdown.Name = "button_User_Dropdown";
            this.button_User_Dropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_User_Dropdown.Size = new System.Drawing.Size(129, 31);
            this.button_User_Dropdown.TabIndex = 7;
            this.button_User_Dropdown.Text = "PXXXXX";
            this.button_User_Dropdown.UseVisualStyleBackColor = false;
            this.button_User_Dropdown.Click += new System.EventHandler(this.button_User_Dropdown_Click);
            // 
            // imageList_Buttons
            // 
            this.imageList_Buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Buttons.ImageStream")));
            this.imageList_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Buttons.Images.SetKeyName(0, "dropdown-active.png");
            this.imageList_Buttons.Images.SetKeyName(1, "dropdown-inactive.png");
            this.imageList_Buttons.Images.SetKeyName(2, "logout.png");
            // 
            // imageList_BigButtons
            // 
            this.imageList_BigButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_BigButtons.ImageStream")));
            this.imageList_BigButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_BigButtons.Images.SetKeyName(0, "projects_icon.png");
            this.imageList_BigButtons.Images.SetKeyName(1, "teams_icon2.png");
            this.imageList_BigButtons.Images.SetKeyName(2, "users.png");
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_Container.Controls.Add(this.button_Show_Assignments);
            this.panel_Container.Controls.Add(this.button_Show_Team);
            this.panel_Container.Controls.Add(this.button_Show_Users);
            this.panel_Container.Location = new System.Drawing.Point(44, 115);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(366, 337);
            this.panel_Container.TabIndex = 8;
            // 
            // button_Show_Assignments
            // 
            this.button_Show_Assignments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Show_Assignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.button_Show_Assignments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Show_Assignments.FlatAppearance.BorderSize = 0;
            this.button_Show_Assignments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Show_Assignments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Show_Assignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show_Assignments.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show_Assignments.ForeColor = System.Drawing.Color.White;
            this.button_Show_Assignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Show_Assignments.ImageKey = "projects_icon.png";
            this.button_Show_Assignments.ImageList = this.imageList_BigButtons;
            this.button_Show_Assignments.Location = new System.Drawing.Point(30, 42);
            this.button_Show_Assignments.Name = "button_Show_Assignments";
            this.button_Show_Assignments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Show_Assignments.Size = new System.Drawing.Size(304, 71);
            this.button_Show_Assignments.TabIndex = 28;
            this.button_Show_Assignments.Text = "         ΠΡΟΒΟΛΗ ΕΡΓΑΣΙΩΝ";
            this.button_Show_Assignments.UseVisualStyleBackColor = false;
            this.button_Show_Assignments.Click += new System.EventHandler(this.button_Show_Assignments_Click);
            // 
            // button_Show_Team
            // 
            this.button_Show_Team.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Show_Team.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.button_Show_Team.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Show_Team.FlatAppearance.BorderSize = 0;
            this.button_Show_Team.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Show_Team.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Show_Team.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show_Team.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show_Team.ForeColor = System.Drawing.Color.White;
            this.button_Show_Team.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Show_Team.ImageIndex = 1;
            this.button_Show_Team.ImageList = this.imageList_BigButtons;
            this.button_Show_Team.Location = new System.Drawing.Point(30, 132);
            this.button_Show_Team.Name = "button_Show_Team";
            this.button_Show_Team.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Show_Team.Size = new System.Drawing.Size(304, 71);
            this.button_Show_Team.TabIndex = 26;
            this.button_Show_Team.Text = "         ΠΡΟΒΟΛΗ ΟΜΑΔΩΝ";
            this.button_Show_Team.UseVisualStyleBackColor = false;
            this.button_Show_Team.Click += new System.EventHandler(this.button_Show_Team_Click);
            // 
            // button_Show_Users
            // 
            this.button_Show_Users.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Show_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.button_Show_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Show_Users.FlatAppearance.BorderSize = 0;
            this.button_Show_Users.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Show_Users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Show_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show_Users.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show_Users.ForeColor = System.Drawing.Color.White;
            this.button_Show_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Show_Users.ImageKey = "users.png";
            this.button_Show_Users.ImageList = this.imageList_BigButtons;
            this.button_Show_Users.Location = new System.Drawing.Point(30, 221);
            this.button_Show_Users.Name = "button_Show_Users";
            this.button_Show_Users.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Show_Users.Size = new System.Drawing.Size(304, 71);
            this.button_Show_Users.TabIndex = 27;
            this.button_Show_Users.Text = "         ΠΡΟΒΟΛΗ ΧΡΗΣΤΩΝ";
            this.button_Show_Users.UseVisualStyleBackColor = false;
            this.button_Show_Users.Click += new System.EventHandler(this.button_Show_Users_Click);
            // 
            // panel_User_Dropdown
            // 
            this.panel_User_Dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_User_Dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_User_Dropdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_User_Dropdown.Controls.Add(this.button_Logout);
            this.panel_User_Dropdown.Location = new System.Drawing.Point(280, 56);
            this.panel_User_Dropdown.Name = "panel_User_Dropdown";
            this.panel_User_Dropdown.Size = new System.Drawing.Size(130, 41);
            this.panel_User_Dropdown.TabIndex = 25;
            this.panel_User_Dropdown.Visible = false;
            // 
            // button_Logout
            // 
            this.button_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Logout.BackColor = System.Drawing.Color.Transparent;
            this.button_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(123)))));
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.ForeColor = System.Drawing.Color.White;
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.ImageKey = "logout.png";
            this.button_Logout.ImageList = this.imageList_Buttons;
            this.button_Logout.Location = new System.Drawing.Point(3, 3);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Logout.Size = new System.Drawing.Size(143, 31);
            this.button_Logout.TabIndex = 1;
            this.button_Logout.Text = "Αποσύνδεση";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // Form_Admin_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(455, 481);
            this.Controls.Add(this.panel_User_Dropdown);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel_Menu_Header);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Admin_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Projects | Μενού Διαχειριστή";
            this.Load += new System.EventHandler(this.Form_Lobby_Load);
            this.panel_Menu_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Profile)).EndInit();
            this.panel_Container.ResumeLayout(false);
            this.panel_User_Dropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu_Header;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.ImageList imageList_BigButtons;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.PictureBox pictureBox_Admin_Icon;
        private System.Windows.Forms.PictureBox pictureBox_User_Profile;
        private System.Windows.Forms.Button button_User_Dropdown;
        private System.Windows.Forms.Button button_Show_Assignments;
        private System.Windows.Forms.Button button_Show_Team;
        private System.Windows.Forms.Button button_Show_Users;
        private System.Windows.Forms.Panel panel_User_Dropdown;
        private System.Windows.Forms.Button button_Logout;
    }
}