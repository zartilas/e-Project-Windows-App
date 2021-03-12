namespace e_Projects.Forms.Admin
{
    partial class Form_Admin_Assign_Grade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Assign_Grade));
            this.textBox_Grade = new System.Windows.Forms.TextBox();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.label_Max_Grade = new System.Windows.Forms.Label();
            this.panel_Container_Header = new System.Windows.Forms.Panel();
            this.label_Team_Title = new System.Windows.Forms.Label();
            this.label_Grade = new System.Windows.Forms.Label();
            this.button_Submit_Grade = new System.Windows.Forms.Button();
            this.panel_Login.SuspendLayout();
            this.panel_Container_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Grade
            // 
            this.textBox_Grade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.textBox_Grade.ForeColor = System.Drawing.Color.White;
            this.textBox_Grade.Location = new System.Drawing.Point(193, 75);
            this.textBox_Grade.MaxLength = 2;
            this.textBox_Grade.Name = "textBox_Grade";
            this.textBox_Grade.ShortcutsEnabled = false;
            this.textBox_Grade.Size = new System.Drawing.Size(183, 30);
            this.textBox_Grade.TabIndex = 1;
            this.textBox_Grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Grade_KeyPress);
            // 
            // panel_Login
            // 
            this.panel_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_Login.AutoScroll = true;
            this.panel_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.panel_Login.Controls.Add(this.label_Max_Grade);
            this.panel_Login.Controls.Add(this.panel_Container_Header);
            this.panel_Login.Controls.Add(this.label_Grade);
            this.panel_Login.Controls.Add(this.textBox_Grade);
            this.panel_Login.Controls.Add(this.button_Submit_Grade);
            this.panel_Login.Location = new System.Drawing.Point(21, 18);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(550, 228);
            this.panel_Login.TabIndex = 4;
            // 
            // label_Max_Grade
            // 
            this.label_Max_Grade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Max_Grade.BackColor = System.Drawing.Color.Transparent;
            this.label_Max_Grade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Max_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Max_Grade.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Max_Grade.ForeColor = System.Drawing.Color.White;
            this.label_Max_Grade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Max_Grade.Location = new System.Drawing.Point(192, 51);
            this.label_Max_Grade.Name = "label_Max_Grade";
            this.label_Max_Grade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Max_Grade.Size = new System.Drawing.Size(187, 21);
            this.label_Max_Grade.TabIndex = 672;
            this.label_Max_Grade.Text = "Μέγιστος Βαθμός: ";
            this.label_Max_Grade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Container_Header
            // 
            this.panel_Container_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.panel_Container_Header.Controls.Add(this.label_Team_Title);
            this.panel_Container_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Container_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Container_Header.Name = "panel_Container_Header";
            this.panel_Container_Header.Size = new System.Drawing.Size(550, 48);
            this.panel_Container_Header.TabIndex = 1;
            // 
            // label_Team_Title
            // 
            this.label_Team_Title.AutoSize = true;
            this.label_Team_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.label_Team_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Team_Title.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Team_Title.Location = new System.Drawing.Point(10, 10);
            this.label_Team_Title.Name = "label_Team_Title";
            this.label_Team_Title.Size = new System.Drawing.Size(98, 26);
            this.label_Team_Title.TabIndex = 1;
            this.label_Team_Title.Text = "label_title";
            // 
            // label_Grade
            // 
            this.label_Grade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Grade.BackColor = System.Drawing.Color.Transparent;
            this.label_Grade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Grade.ForeColor = System.Drawing.Color.White;
            this.label_Grade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Grade.Location = new System.Drawing.Point(46, 75);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Grade.Size = new System.Drawing.Size(141, 29);
            this.label_Grade.TabIndex = 671;
            this.label_Grade.Text = "Βαθμός:";
            this.label_Grade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Submit_Grade
            // 
            this.button_Submit_Grade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Submit_Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.button_Submit_Grade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Submit_Grade.FlatAppearance.BorderSize = 0;
            this.button_Submit_Grade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Submit_Grade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.button_Submit_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit_Grade.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit_Grade.ForeColor = System.Drawing.Color.White;
            this.button_Submit_Grade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Submit_Grade.Location = new System.Drawing.Point(193, 126);
            this.button_Submit_Grade.Name = "button_Submit_Grade";
            this.button_Submit_Grade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Submit_Grade.Size = new System.Drawing.Size(183, 36);
            this.button_Submit_Grade.TabIndex = 2;
            this.button_Submit_Grade.Text = "ΥΠΟΒΟΛΗ";
            this.button_Submit_Grade.UseVisualStyleBackColor = false;
            this.button_Submit_Grade.Click += new System.EventHandler(this.button_Submit_Grade_Click);
            // 
            // Form_Admin_Assign_Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(590, 268);
            this.Controls.Add(this.panel_Login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Admin_Assign_Grade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Projects | Περιγραφή Εργασίας";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Admin_Assign_Grades_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_Container_Header.ResumeLayout(false);
            this.panel_Container_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Grade;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Panel panel_Container_Header;
        private System.Windows.Forms.Label label_Team_Title;
        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.Button button_Submit_Grade;
        private System.Windows.Forms.Label label_Max_Grade;
    }
}