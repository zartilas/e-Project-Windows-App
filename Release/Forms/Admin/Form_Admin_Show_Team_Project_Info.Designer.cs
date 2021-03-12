namespace e_Projects.Forms.Admin
{
    partial class Form_Admin_Show_Team_Project_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Show_Team_Project_Info));
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_Container_Header = new System.Windows.Forms.Panel();
            this.label_ID_Title = new System.Windows.Forms.Label();
            this.label_Grade_Percent = new System.Windows.Forms.Label();
            this.label_Project_Info_Title = new System.Windows.Forms.Label();
            this.label_Deadline = new System.Windows.Forms.Label();
            this.label_Project_Desc_Title = new System.Windows.Forms.Label();
            this.label_Project_Name_Title = new System.Windows.Forms.Label();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Container.SuspendLayout();
            this.panel_Container_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_Container.Controls.Add(this.panel_Container_Header);
            this.panel_Container.Location = new System.Drawing.Point(12, 12);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1193, 570);
            this.panel_Container.TabIndex = 0;
            // 
            // panel_Container_Header
            // 
            this.panel_Container_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.panel_Container_Header.Controls.Add(this.label_ID_Title);
            this.panel_Container_Header.Controls.Add(this.label_Grade_Percent);
            this.panel_Container_Header.Controls.Add(this.label_Project_Info_Title);
            this.panel_Container_Header.Controls.Add(this.label_Deadline);
            this.panel_Container_Header.Controls.Add(this.label_Project_Desc_Title);
            this.panel_Container_Header.Controls.Add(this.label_Project_Name_Title);
            this.panel_Container_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Container_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Container_Header.Name = "panel_Container_Header";
            this.panel_Container_Header.Size = new System.Drawing.Size(1193, 95);
            this.panel_Container_Header.TabIndex = 1;
            // 
            // label_ID_Title
            // 
            this.label_ID_Title.AutoSize = true;
            this.label_ID_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_ID_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID_Title.Location = new System.Drawing.Point(10, 56);
            this.label_ID_Title.Name = "label_ID_Title";
            this.label_ID_Title.Size = new System.Drawing.Size(123, 26);
            this.label_ID_Title.TabIndex = 5;
            this.label_ID_Title.Text = "ID Εργασίας:";
            // 
            // label_Grade_Percent
            // 
            this.label_Grade_Percent.AutoSize = true;
            this.label_Grade_Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Grade_Percent.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Grade_Percent.Location = new System.Drawing.Point(1017, 56);
            this.label_Grade_Percent.Name = "label_Grade_Percent";
            this.label_Grade_Percent.Size = new System.Drawing.Size(170, 26);
            this.label_Grade_Percent.TabIndex = 9;
            this.label_Grade_Percent.Text = "Ποσοστό Βαθμού:";
            this.label_Grade_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Project_Info_Title
            // 
            this.label_Project_Info_Title.AutoSize = true;
            this.label_Project_Info_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Project_Info_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_Info_Title.Location = new System.Drawing.Point(10, 10);
            this.label_Project_Info_Title.Name = "label_Project_Info_Title";
            this.label_Project_Info_Title.Size = new System.Drawing.Size(297, 26);
            this.label_Project_Info_Title.TabIndex = 1;
            this.label_Project_Info_Title.Text = "Πληροφορίες Εργασίας Ομάδας:";
            // 
            // label_Deadline
            // 
            this.label_Deadline.AutoSize = true;
            this.label_Deadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Deadline.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Deadline.Location = new System.Drawing.Point(776, 56);
            this.label_Deadline.Name = "label_Deadline";
            this.label_Deadline.Size = new System.Drawing.Size(116, 26);
            this.label_Deadline.TabIndex = 8;
            this.label_Deadline.Text = "Προθεσμία:";
            // 
            // label_Project_Desc_Title
            // 
            this.label_Project_Desc_Title.AutoSize = true;
            this.label_Project_Desc_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Project_Desc_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_Desc_Title.Location = new System.Drawing.Point(615, 56);
            this.label_Project_Desc_Title.Name = "label_Project_Desc_Title";
            this.label_Project_Desc_Title.Size = new System.Drawing.Size(117, 26);
            this.label_Project_Desc_Title.TabIndex = 7;
            this.label_Project_Desc_Title.Text = "Περιγραφή:";
            // 
            // label_Project_Name_Title
            // 
            this.label_Project_Name_Title.AutoSize = true;
            this.label_Project_Name_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Project_Name_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_Name_Title.Location = new System.Drawing.Point(139, 56);
            this.label_Project_Name_Title.Name = "label_Project_Name_Title";
            this.label_Project_Name_Title.Size = new System.Drawing.Size(158, 26);
            this.label_Project_Name_Title.TabIndex = 6;
            this.label_Project_Name_Title.Text = "Τίτλος Εργασίας:";
            // 
            // imageList_Buttons
            // 
            this.imageList_Buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Buttons.ImageStream")));
            this.imageList_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Buttons.Images.SetKeyName(0, "dropdown-active.png");
            this.imageList_Buttons.Images.SetKeyName(1, "dropdown-inactive.png");
            this.imageList_Buttons.Images.SetKeyName(2, "logout.png");
            this.imageList_Buttons.Images.SetKeyName(3, "visibility.png");
            // 
            // Form_Admin_Show_Team_Project_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1217, 594);
            this.Controls.Add(this.panel_Container);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Admin_Show_Team_Project_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Projects | Πληροφορίες Εργασίας";
            this.Load += new System.EventHandler(this.Form_Admin_Show_Team_Project_Info_Load);
            this.panel_Container.ResumeLayout(false);
            this.panel_Container_Header.ResumeLayout(false);
            this.panel_Container_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Panel panel_Container_Header;
        private System.Windows.Forms.Label label_Project_Info_Title;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Label label_ID_Title;
        private System.Windows.Forms.Label label_Grade_Percent;
        private System.Windows.Forms.Label label_Deadline;
        private System.Windows.Forms.Label label_Project_Desc_Title;
        private System.Windows.Forms.Label label_Project_Name_Title;
    }
}