using e_Projects.Classes;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms
{
    public partial class Form_Student_Menu : Form
    {
        private bool toggle_dropdown = false;
        private String user_am;

        public Form_Student_Menu(String user_am)
        {
            InitializeComponent();
            this.user_am = user_am;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            button_User_Dropdown.Text = user_am;
        }

        private void button_User_Dropdown_Click(object sender, EventArgs e)
        {
            if (toggle_dropdown == true)
            {
                panel_User_Dropdown.Visible = false;
                toggle_dropdown = false;
                button_User_Dropdown.ImageIndex = 1;
            }
            else
            {
                panel_User_Dropdown.Visible = true;
                toggle_dropdown = true;
                button_User_Dropdown.ImageIndex = 0;
            }
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            new User().Logout(this);
        }

        private void button_View_Projects_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_Available_Projects = new Form_Student_Available_Projects(button_User_Dropdown.Text);
            form_Available_Projects.Closed += (s, args) => this.Close();
            form_Available_Projects.Show();
        }

        private void button_My_Projects_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_My_Projects = new Form_Student_My_Projects(button_User_Dropdown.Text);
            form_My_Projects.Closed += (s, args) => this.Close();
            form_My_Projects.Show();
        }

        private void button_View_Grades_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_My_Grades = new Form_Student_My_Grades(button_User_Dropdown.Text);
            form_My_Grades.Closed += (s, args) => this.Close();
            form_My_Grades.Show();
        }
    }
}