using System;
using System.Drawing;
using System.Windows.Forms;

namespace e_Projects.Forms.Admin
{
    public partial class Form_Admin_Show_Assignment_Description : Form
    {
        private String project_name;
        private String project_desc;

        public Form_Admin_Show_Assignment_Description(String project_name, String project_desc)
        {
            InitializeComponent();
            this.project_name = project_name;
            this.project_desc = project_desc;

            this.Text = "e-Projects | " + project_name + " | Περιγραφή Εργασίας";
            label_Project_Desc_Title.Text = project_name + " | Περιγραφή Εργασίας:";
            label_Description.Text = project_desc;
            label_Description.MaximumSize = new Size(1100, 0);
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }
    }
}