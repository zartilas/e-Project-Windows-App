using e_Projects.Classes;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms
{
    public partial class Form_Admin_Menu : Form
    {
        private bool toggle_dropdown = false;
        private String user_am;

        public Form_Admin_Menu(String user_am)
        {
            InitializeComponent();
            this.user_am = user_am;
        }

        private void Form_Lobby_Load(object sender, EventArgs e)
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

        private void button_Show_Assignments_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_Show_Projects = new Form_Admin_Show_Assignments(button_User_Dropdown.Text);
            form_Show_Projects.Closed += (s, args) => this.Close();
            form_Show_Projects.Show();
        }

        private void button_Show_Users_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_Show_Users = new Form_Admin_Show_Users(button_User_Dropdown.Text);
            form_Show_Users.Closed += (s, args) => this.Close();
            form_Show_Users.Show();
        }

        private void button_Show_Team_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_Show_Teams = new Form_Admin_Show_Teams(button_User_Dropdown.Text);
            form_Show_Teams.Closed += (s, args) => this.Close();
            form_Show_Teams.Show();
        }
    }
}