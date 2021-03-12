namespace e_Projects.Forms.Admin
{
    partial class Form_Admin_Show_Assignment_Description
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Show_Assignment_Description));
            this.panel_Container_Header = new System.Windows.Forms.Panel();
            this.label_Project_Desc_Title = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_Container_Header.SuspendLayout();
            this.panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Container_Header
            // 
            this.panel_Container_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.panel_Container_Header.Controls.Add(this.label_Project_Desc_Title);
            this.panel_Container_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Container_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Container_Header.Name = "panel_Container_Header";
            this.panel_Container_Header.Size = new System.Drawing.Size(1150, 48);
            this.panel_Container_Header.TabIndex = 1;
            // 
            // label_Project_Desc_Title
            // 
            this.label_Project_Desc_Title.AutoSize = true;
            this.label_Project_Desc_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Project_Desc_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Project_Desc_Title.Location = new System.Drawing.Point(10, 10);
            this.label_Project_Desc_Title.Name = "label_Project_Desc_Title";
            this.label_Project_Desc_Title.Size = new System.Drawing.Size(117, 26);
            this.label_Project_Desc_Title.TabIndex = 1;
            this.label_Project_Desc_Title.Text = "Περιγραφή:";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(10, 64);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(46, 23);
            this.label_Description.TabIndex = 2;
            this.label_Description.Text = "label";
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(168)))));
            this.panel_Container.Controls.Add(this.label_Description);
            this.panel_Container.Controls.Add(this.panel_Container_Header);
            this.panel_Container.Location = new System.Drawing.Point(12, 12);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1150, 570);
            this.panel_Container.TabIndex = 0;
            // 
            // Form_Admin_Show_Assignment_Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1174, 594);
            this.Controls.Add(this.panel_Container);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Admin_Show_Assignment_Description";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Projects | Περιγραφή Εργασίας";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel_Container_Header.ResumeLayout(false);
            this.panel_Container_Header.PerformLayout();
            this.panel_Container.ResumeLayout(false);
            this.panel_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container_Header;
        private System.Windows.Forms.Label label_Project_Desc_Title;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Panel panel_Container;
    }
}