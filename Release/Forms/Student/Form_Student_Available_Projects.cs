using e_Projects.Classes;
using e_Projects.Properties;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms
{
    public partial class Form_Student_Available_Projects : Form
    {
        private bool toggle_dropdown = false;
        private String user_am;

        public Form_Student_Available_Projects(String user_am)
        {
            InitializeComponent();
            this.user_am = user_am;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            button_User_Settings.Text = user_am;
            Create_Controls();
        }

        private void button_User_Dropdown_Click(object sender, EventArgs e)
        {
            if (toggle_dropdown == true)
            {
                panel_User_Settings.Visible = false;
                toggle_dropdown = false;
                button_User_Settings.ImageIndex = 1;
            }
            else
            {
                panel_User_Settings.Visible = true;
                toggle_dropdown = true;
                button_User_Settings.ImageIndex = 0;
            }
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            new User().Logout(this);
        }

        private void pictureBox_Back_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Back.Image = Resources.return_active;
        }

        private void pictureBox_Back_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Back.Image = Resources.return_inactive;
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_lobby = new Form_Student_Menu(button_User_Settings.Text);
            form_lobby.Closed += (s, args) => this.Close();
            form_lobby.Show();
        }

        public void Refresh_Controls()
        {
            panel_Container.Controls.Clear();
            Create_Controls();
        }

        public void Create_Controls()
        {
            ControlsDesigner controlsDesigner = new ControlsDesigner();
            controlsDesigner.Create_Available_Projects_Controls(this, panel_Container, imageList_Buttons, user_am,
                                                                label_Project_Name_Title.Location.X,
                                                                label_Project_Desc_Title.Location.X,
                                                                label_Deadline_Title.Location.X,
                                                                label_Grade_Percent_Title.Location.X,
                                                                label_Choosen_Title.Location.X,
                                                                label_Actions_Title.Location.X,
                                                                label_Uploaded_Title.Location.X);
        }
    }
}