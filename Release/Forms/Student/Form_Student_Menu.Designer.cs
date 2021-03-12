namespace e_Projects.Forms
{
    partial class Form_Student_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Student_Menu));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.pictureBox_User_Profile = new System.Windows.Forms.PictureBox();
            this.button_User_Dropdown = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_User_Dropdown = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.imageList_BigButtons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Container = new System.Windows.Forms.Panel();
            this.button_View_Projects = new System.Windows.Forms.Button();
            this.button_My_Projects = new System.Windows.Forms.Button();
            this.button_View_Grades = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Profile)).BeginInit();
            this.panel_User_Dropdown.SuspendLayout();
            this.panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.panel_Menu.Controls.Add(this.pictureBox_User_Profile);
            this.panel_Menu.Controls.Add(this.button_User_Dropdown);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(455, 85);
            this.panel_Menu.TabIndex = 5;
            // 
            // pictureBox_User_Profile
            // 
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
            // panel_User_Dropdown
            // 
            this.panel_User_Dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_User_Dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_User_Dropdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_User_Dropdown.Controls.Add(this.button_Logout);
            this.panel_User_Dropdown.Location = new System.Drawing.Point(280, 56);
            this.panel_User_Dropdown.Name = "panel_User_Dropdown";
            this.panel_User_Dropdown.Size = new System.Drawing.Size(130, 41);
            this.panel_User_Dropdown.TabIndex = 6;
            this.panel_User_Dropdown.Visible = false;
            // 
            // button_Logout
            // 
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
            this.button_Logout.TabIndex = 0;
            this.button_Logout.TabStop = false;
            this.button_Logout.Text = "Αποσύνδεση";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // imageList_BigButtons
            // 
            this.imageList_BigButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_BigButtons.ImageStream")));
            this.imageList_BigButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_BigButtons.Images.SetKeyName(0, "my_projects_icon.png");
            this.imageList_BigButtons.Images.SetKeyName(1, "available_assaignments.png");
            this.imageList_BigButtons.Images.SetKeyName(2, "grades_icon.png");
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_Container.Controls.Add(this.button_View_Grades);
            this.panel_Container.Controls.Add(this.button_View_Projects);
            this.panel_Container.Controls.Add(this.button_My_Projects);
            this.panel_Container.Location = new System.Drawing.Point(44, 115);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(366, 334);
            this.panel_Container.TabIndex = 8;
            // 
            // button_View_Projects
            // 
            this.button_View_Projects.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_View_Projects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.button_View_Projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_View_Projects.FlatAppearance.BorderSize = 0;
            this.button_View_Projects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_View_Projects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_View_Projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View_Projects.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_Projects.ForeColor = System.Drawing.Color.White;
            this.button_View_Projects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_View_Projects.ImageKey = "available_assaignments.png";
            this.button_View_Projects.ImageList = this.imageList_BigButtons;
            this.button_View_Projects.Location = new System.Drawing.Point(30, 42);
            this.button_View_Projects.Name = "button_View_Projects";
            this.button_View_Projects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_View_Projects.Size = new System.Drawing.Size(304, 71);
            this.button_View_Projects.TabIndex = 1;
            this.button_View_Projects.Text = "         ΔΙΑΘΕΣΙΜΕΣ ΕΡΓΑΣΙΕΣ";
            this.button_View_Projects.UseVisualStyleBackColor = false;
            this.button_View_Projects.Click += new System.EventHandler(this.button_View_Projects_Click);
            // 
            // button_My_Projects
            // 
            this.button_My_Projects.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_My_Projects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.button_My_Projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_My_Projects.FlatAppearance.BorderSize = 0;
            this.button_My_Projects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_My_Projects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_My_Projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_My_Projects.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_My_Projects.ForeColor = System.Drawing.Color.White;
            this.button_My_Projects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_My_Projects.ImageKey = "my_projects_icon.png";
            this.button_My_Projects.ImageList = this.imageList_BigButtons;
            this.button_My_Projects.Location = new System.Drawing.Point(30, 132);
            this.button_My_Projects.Name = "button_My_Projects";
            this.button_My_Projects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_My_Projects.Size = new System.Drawing.Size(304, 71);
            this.button_My_Projects.TabIndex = 2;
            this.button_My_Projects.Text = "ΟΙ ΕΡΓΑΣΙΕΣ ΜΟΥ";
            this.button_My_Projects.UseVisualStyleBackColor = false;
            this.button_My_Projects.Click += new System.EventHandler(this.button_My_Projects_Click);
            // 
            // button_View_Grades
            // 
            this.button_View_Grades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_View_Grades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.button_View_Grades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_View_Grades.FlatAppearance.BorderSize = 0;
            this.button_View_Grades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_View_Grades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_View_Grades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View_Grades.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View_Grades.ForeColor = System.Drawing.Color.White;
            this.button_View_Grades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_View_Grades.ImageKey = "grades_icon.png";
            this.button_View_Grades.ImageList = this.imageList_BigButtons;
            this.button_View_Grades.Location = new System.Drawing.Point(30, 224);
            this.button_View_Grades.Name = "button_View_Grades";
            this.button_View_Grades.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_View_Grades.Size = new System.Drawing.Size(304, 71);
            this.button_View_Grades.TabIndex = 3;
            this.button_View_Grades.Text = "ΒΑΘΜΟΙ";
            this.button_View_Grades.UseVisualStyleBackColor = false;
            this.button_View_Grades.Click += new System.EventHandler(this.button_View_Grades_Click);
            // 
            // Form_Student_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(455, 483);
            this.Controls.Add(this.panel_User_Dropdown);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel_Menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_Student_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Projects | Μενού Φοιτητή";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Profile)).EndInit();
            this.panel_User_Dropdown.ResumeLayout(false);
            this.panel_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.PictureBox pictureBox_User_Profile;
        private System.Windows.Forms.Button button_User_Dropdown;
        private System.Windows.Forms.Panel panel_User_Dropdown;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.ImageList imageList_BigButtons;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Button button_My_Projects;
        private System.Windows.Forms.Button button_View_Projects;
        private System.Windows.Forms.Button button_View_Grades;
    }
}