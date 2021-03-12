using e_Projects.Classes;
using e_Projects.Properties;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms
{
    public partial class Form_Admin_Show_Teams : Form
    {
        private bool toggle_dropdown = false;
        private String user_am;

        public Form_Admin_Show_Teams(String user_am)
        {
            InitializeComponent();
            this.user_am = user_am;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            button_User_Dropdown.Text = user_am;
            Create_Controls();
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
            var form_Admin_Menu = new Form_Admin_Menu(button_User_Dropdown.Text);
            form_Admin_Menu.Closed += (s, args) => this.Close();
            form_Admin_Menu.Show();
        }

        public void Create_Controls()
        {
            ControlsDesigner controlsDesigner = new ControlsDesigner();
            controlsDesigner.Create_Teams_Controls(this, panel_Container, imageList_Buttons,
                                                   label_Team_ID_Title.Location.X,
                                                   label_Project_ID_Title.Location.X,
                                                   label_Student_AMs_Title.Location.X,
                                                   label_File_Title.Location.X,
                                                   label_File_Upload_Status_Title.Location.X,
                                                   label_Date_Uploaded.Location.X,
                                                   label_Grade_Title.Location.X,
                                                   label_Actions_Title.Location.X);
        }

        public void Refresh_Controls()
        {
            panel_Container.Controls.Clear();
            Create_Controls();
        }

        private void button_Refresh_List_Click(object sender, EventArgs e)
        {
            Refresh_Controls();
        }
    }
}