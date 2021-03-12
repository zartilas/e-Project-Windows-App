using System;
using System.Drawing;
using System.Windows.Forms;

namespace e_Projects.Forms.Student
{
    public partial class Form_Student_Project_View_Description : Form
    {
        public Form_Student_Project_View_Description(String project_name, String project_desc)
        {
            InitializeComponent();
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