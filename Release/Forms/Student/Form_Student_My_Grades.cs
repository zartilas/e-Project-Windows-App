using e_Projects.Classes;
using e_Projects.Properties;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms
{
    public partial class Form_Student_My_Grades : Form
    {
        private bool toggle_dropdown = false;
        private String user_am;

        public Form_Student_My_Grades(String user_am)
        {
            InitializeComponent();
            this.user_am = user_am;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            button_User_Dropdown.Text = user_am;
            ControlsDesigner controlsDesigner = new ControlsDesigner();
            controlsDesigner.Create_My_Project_Grades_Controls(this, panel_Project_Grades_Container,
                                                               imageList_Buttons, user_am,
                                                               label_Project_Name_Title.Location.X,
                                                               label_Project_Desc_Title.Location.X,
                                                               label_Deadline_Title.Location.X,
                                                               label_Grade_Percent_Title.Location.X,
                                                               label_Uploaded_Title.Location.X,
                                                               label_Status.Location.X,
                                                               label_Grade.Location.X);

            controlsDesigner.Create_My_Subject_Grades_Controls(this, panel_Subjects_Container,
                                                               imageList_Buttons, user_am,
                                                               label_Subject_Name.Location.X,
                                                               label_Subject_Grade.Location.X);
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
            var form_Student_Menu = new Form_Student_Menu(button_User_Dropdown.Text);
            form_Student_Menu.Closed += (s, args) => this.Close();
            form_Student_Menu.Show();
        }
    }
}