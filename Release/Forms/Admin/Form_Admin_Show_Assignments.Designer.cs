﻿namespace e_Projects.Forms
{
    partial class Form_Admin_Show_Assignments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Show_Assignments));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.pictureBox_Admin_Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox_User_Profile = new System.Windows.Forms.PictureBox();
            this.button_User_Dropdown = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Container = new System.Windows.Forms.Panel();
            this.label_Project_ID_Title = new System.Windows.Forms.Label();
            this.panel_Container_Header = new System.Windows.Forms.Panel();
            this.label_Actions_Title = new System.Windows.Forms.Label();
            this.label_Grade_Percent_Title = new System.Windows.Forms.Label();
            this.label_Deadline_Title = new System.Windows.Forms.Label();
            this.label_Project_Name_Title = new System.Windows.Forms.Label();
            this.label_Project_Desc_Title = new System.Windows.Forms.Label();
            this.label_Projects_Header = new System.Windows.Forms.Label();
            this.panel_User_Dropdown = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.imageList_Bigger_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.button_Insert_Assignment = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Profile)).BeginInit();
            this.panel_Container_Header.SuspendLayout();
            this.panel_User_Dropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.panel_Menu.Controls.Add(this.pictureBox_Back);
            this.panel_Menu.Controls.Add(this.pictureBox_Admin_Icon);
            this.panel_Menu.Controls.Add(this.pictureBox_User_Profile);
            this.panel_Menu.Controls.Add(this.button_User_Dropdown);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1400, 85);
            this.panel_Menu.TabIndex = 5;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Image = global::e_Projects.Properties.Resources.return_inactive;
            this.pictureBox_Back.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(67, 65);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Back.TabIndex = 14;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            this.pictureBox_Back.MouseEnter += new System.EventHandler(this.pictureBox_Back_MouseEnter);
            this.pictureBox_Back.MouseLeave += new System.EventHandler(this.pictureBox_Back_MouseLeave);
            // 
            // pictureBox_Admin_Icon
            // 
            this.pictureBox_Admin_Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Admin_Icon.Image = global::e_Projects.Properties.Resources.admin_icon;
            this.pictureBox_Admin_Icon.Location = new System.Drawing.Point(1133, 23);
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
            this.pictureBox_User_Profile.Location = new System.Drawing.Point(1174, 17);
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
            this.button_User_Dropdown.Location = new System.Drawing.Point(1199, 23);
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
            this.imageList_Buttons.Images.SetKeyName(3, "visibility.png");
            this.imageList_Buttons.Images.SetKeyName(4, "remove.png");
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Container.AutoScroll = true;
            this.panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_Container.Location = new System.Drawing.Point(44, 165);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1313, 447);
            this.panel_Container.TabIndex = 8;
            // 
            // label_Project_ID_Title
            // 
            this.label_Project_ID_Title.AutoSize = true;
            this.label_Project_ID_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Project_ID_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Project_ID_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_ID_Title.Location = new System.Drawing.Point(10, 10);
            this.label_Project_ID_Title.Name = "label_Project_ID_Title";
            this.label_Project_ID_Title.Size = new System.Drawing.Size(123, 26);
            this.label_Project_ID_Title.TabIndex = 0;
            this.label_Project_ID_Title.Text = "ID Εργασίας:";
            // 
            // panel_Container_Header
            // 
            this.panel_Container_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Container_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.panel_Container_Header.Controls.Add(this.label_Actions_Title);
            this.panel_Container_Header.Controls.Add(this.label_Project_ID_Title);
            this.panel_Container_Header.Controls.Add(this.label_Grade_Percent_Title);
            this.panel_Container_Header.Controls.Add(this.label_Deadline_Title);
            this.panel_Container_Header.Controls.Add(this.label_Project_Name_Title);
            this.panel_Container_Header.Controls.Add(this.label_Project_Desc_Title);
            this.panel_Container_Header.Location = new System.Drawing.Point(44, 126);
            this.panel_Container_Header.Name = "panel_Container_Header";
            this.panel_Container_Header.Size = new System.Drawing.Size(1313, 43);
            this.panel_Container_Header.TabIndex = 7;
            // 
            // label_Actions_Title
            // 
            this.label_Actions_Title.AutoSize = true;
            this.label_Actions_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Actions_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Actions_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Actions_Title.Location = new System.Drawing.Point(1207, 10);
            this.label_Actions_Title.Name = "label_Actions_Title";
            this.label_Actions_Title.Size = new System.Drawing.Size(104, 26);
            this.label_Actions_Title.TabIndex = 15;
            this.label_Actions_Title.Text = "Ενέργειες:";
            this.label_Actions_Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Grade_Percent_Title
            // 
            this.label_Grade_Percent_Title.AutoSize = true;
            this.label_Grade_Percent_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Grade_Percent_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Grade_Percent_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Grade_Percent_Title.Location = new System.Drawing.Point(1017, 10);
            this.label_Grade_Percent_Title.Name = "label_Grade_Percent_Title";
            this.label_Grade_Percent_Title.Size = new System.Drawing.Size(170, 26);
            this.label_Grade_Percent_Title.TabIndex = 4;
            this.label_Grade_Percent_Title.Text = "Ποσοστό Βαθμού:";
            // 
            // label_Deadline_Title
            // 
            this.label_Deadline_Title.AutoSize = true;
            this.label_Deadline_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Deadline_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Deadline_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Deadline_Title.Location = new System.Drawing.Point(776, 10);
            this.label_Deadline_Title.Name = "label_Deadline_Title";
            this.label_Deadline_Title.Size = new System.Drawing.Size(116, 26);
            this.label_Deadline_Title.TabIndex = 3;
            this.label_Deadline_Title.Text = "Προθεσμία:";
            // 
            // label_Project_Name_Title
            // 
            this.label_Project_Name_Title.AutoSize = true;
            this.label_Project_Name_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Project_Name_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Project_Name_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_Name_Title.Location = new System.Drawing.Point(139, 10);
            this.label_Project_Name_Title.Name = "label_Project_Name_Title";
            this.label_Project_Name_Title.Size = new System.Drawing.Size(158, 26);
            this.label_Project_Name_Title.TabIndex = 1;
            this.label_Project_Name_Title.Text = "Τίτλος Εργασίας:";
            // 
            // label_Project_Desc_Title
            // 
            this.label_Project_Desc_Title.AutoSize = true;
            this.label_Project_Desc_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Project_Desc_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Project_Desc_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_Desc_Title.Location = new System.Drawing.Point(615, 10);
            this.label_Project_Desc_Title.Name = "label_Project_Desc_Title";
            this.label_Project_Desc_Title.Size = new System.Drawing.Size(117, 26);
            this.label_Project_Desc_Title.TabIndex = 2;
            this.label_Project_Desc_Title.Text = "Περιγραφή:";
            // 
            // label_Projects_Header
            // 
            this.label_Projects_Header.AutoSize = true;
            this.label_Projects_Header.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Projects_Header.Location = new System.Drawing.Point(40, 100);
            this.label_Projects_Header.Name = "label_Projects_Header";
            this.label_Projects_Header.Size = new System.Drawing.Size(85, 23);
            this.label_Projects_Header.TabIndex = 14;
            this.label_Projects_Header.Text = "Εργασίες:";
            // 
            // panel_User_Dropdown
            // 
            this.panel_User_Dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_User_Dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_User_Dropdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_User_Dropdown.Controls.Add(this.button_Logout);
            this.panel_User_Dropdown.Location = new System.Drawing.Point(1231, 57);
            this.panel_User_Dropdown.Name = "panel_User_Dropdown";
            this.panel_User_Dropdown.Size = new System.Drawing.Size(124, 44);
            this.panel_User_Dropdown.TabIndex = 13;
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
            this.button_Logout.Location = new System.Drawing.Point(3, 5);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Logout.Size = new System.Drawing.Size(143, 31);
            this.button_Logout.TabIndex = 1;
            this.button_Logout.Text = "Αποσύνδεση";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.ForeColor = System.Drawing.Color.White;
            this.button_Refresh.ImageKey = "refresh.png";
            this.button_Refresh.ImageList = this.imageList_Bigger_Buttons;
            this.button_Refresh.Location = new System.Drawing.Point(0, 126);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Refresh.Size = new System.Drawing.Size(39, 43);
            this.button_Refresh.TabIndex = 16;
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_List_Click);
            // 
            // imageList_Bigger_Buttons
            // 
            this.imageList_Bigger_Buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Bigger_Buttons.ImageStream")));
            this.imageList_Bigger_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Bigger_Buttons.Images.SetKeyName(0, "refresh.png");
            this.imageList_Bigger_Buttons.Images.SetKeyName(1, "add_assignment.png");
            // 
            // button_Insert_Assignment
            // 
            this.button_Insert_Assignment.BackColor = System.Drawing.Color.Transparent;
            this.button_Insert_Assignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insert_Assignment.FlatAppearance.BorderSize = 0;
            this.button_Insert_Assignment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Insert_Assignment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Insert_Assignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insert_Assignment.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Insert_Assignment.ForeColor = System.Drawing.Color.White;
            this.button_Insert_Assignment.ImageKey = "add_assignment.png";
            this.button_Insert_Assignment.ImageList = this.imageList_Bigger_Buttons;
            this.button_Insert_Assignment.Location = new System.Drawing.Point(2, 175);
            this.button_Insert_Assignment.Name = "button_Insert_Assignment";
            this.button_Insert_Assignment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Insert_Assignment.Size = new System.Drawing.Size(39, 43);
            this.button_Insert_Assignment.TabIndex = 17;
            this.button_Insert_Assignment.UseVisualStyleBackColor = false;
            this.button_Insert_Assignment.Click += new System.EventHandler(this.button_Insert_Assignment_Click);
            // 
            // Form_Admin_Show_Assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1400, 649);
            this.Controls.Add(this.button_Insert_Assignment);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Projects_Header);
            this.Controls.Add(this.panel_Container_Header);
            this.Controls.Add(this.panel_User_Dropdown);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel_Menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Admin_Show_Assignments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Projects | Προβολή Εργασιών";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_Profile)).EndInit();
            this.panel_Container_Header.ResumeLayout(false);
            this.panel_Container_Header.PerformLayout();
            this.panel_User_Dropdown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.PictureBox pictureBox_Admin_Icon;
        private System.Windows.Forms.PictureBox pictureBox_User_Profile;
        private System.Windows.Forms.Button button_User_Dropdown;
        private System.Windows.Forms.Label label_Projects_Header;
        private System.Windows.Forms.Panel panel_User_Dropdown;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.Label label_Project_ID_Title;
        private System.Windows.Forms.Label label_Project_Name_Title;
        private System.Windows.Forms.Label label_Project_Desc_Title;
        private System.Windows.Forms.Panel panel_Container_Header;
        private System.Windows.Forms.Label label_Grade_Percent_Title;
        private System.Windows.Forms.Label label_Deadline_Title;
        private System.Windows.Forms.Label label_Actions_Title;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ImageList imageList_Bigger_Buttons;
        private System.Windows.Forms.Button button_Insert_Assignment;
    }
}