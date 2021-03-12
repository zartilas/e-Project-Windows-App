using e_Projects.Classes;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace e_Projects.Forms.Admin
{
    public partial class Form_Student_Project_Add_Team : Form
    {
        private int active_Student_Containers = 1;
        private bool new_team_added = false;
        private int project_id;
        private int max_project_students;

        private Form_Student_Available_Projects form_Student_Available_Projects = null;
        private Utilities utils = new Utilities();
        private student student = new student();

        public Form_Student_Project_Add_Team(Form_Student_Available_Projects form_Student_Available_Projects, int project_id)
        {
            InitializeComponent();
            this.project_id = project_id;
            this.max_project_students = student.Get_Project_Max_Students_Number(project_id);

            this.form_Student_Available_Projects = form_Student_Available_Projects;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            utils.add_Tooltip(button_Add_Student, Messages.tooltip_add_more_students);
            label_Max_Students.Text += max_project_students;
        }

        private void button_Submit_Team_Click(object sender, EventArgs e)
        {
            String student_ids = "";
            for (int i = 1; i <= active_Student_Containers; i++)
            {
                Control textBox_Name = utils.Find_Control(this.Controls, "textBox_Student_Name_" + i);
                Control textBox_Surname = utils.Find_Control(this.Controls, "textBox_Student_Surname_" + i);
                Control textBox_AM = utils.Find_Control(this.Controls, "textBox_Student_AM_" + i);
                Control textBox_Email = utils.Find_Control(this.Controls, "textBox_Student_Email_" + i);
                if (string.IsNullOrEmpty(textBox_Name.Text) ||
                    string.IsNullOrEmpty(textBox_Surname.Text) ||
                    string.IsNullOrEmpty(textBox_AM.Text) ||
                    string.IsNullOrEmpty(textBox_Email.Text))
                {
                    MessageBox.Show(Messages.error_message_empty_fields,
                                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.Match(textBox_Name.Text, @"^[a-zA-Z]+$").Success ||
                    !Regex.Match(textBox_Name.Text, @"^[α-ωΑ-Ω]+$").Success)
                {
                    MessageBox.Show(Messages.msgbox_invalid_Name_error,
                                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.Match(textBox_Surname.Text, @"^[a-zA-Z]+$").Success ||
                    !Regex.Match(textBox_Surname.Text, @"^[α-ωΑ-Ω]+$").Success)
                {
                    MessageBox.Show(Messages.msgbox_invalid_Surname_error,
                                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.Match(textBox_AM.Text.ToUpper().Replace("Π", "P"), @"^([P][0-9]{5})*$").Success)
                {
                    MessageBox.Show(Messages.msgbox_invalid_AM_format_error,
                                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.Match(textBox_Email.Text, @"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$").Success)
                {
                    MessageBox.Show(Messages.msgbox_invalid_Email_error,
                                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                DatabaseChecks dbChecks = new DatabaseChecks();
                if (!dbChecks.Check_Ιf_User_AM_Is_Registered(textBox_AM.Text))
                {
                    MessageBox.Show(Messages.msgbox_AM_Not_Registered,
                                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (!dbChecks.Check_If_User_AM_Exists_In_Another_Team(textBox_AM.Text, project_id))
                {
                    MessageBox.Show(Messages.msgbox_AM_Is_In_Another_Team_Of_The_Same_Project,
                                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(student_ids))
                    student_ids += textBox_AM.Text;
                else
                    student_ids += ", " + textBox_AM.Text;
            }
            if (student.Add_Team(project_id, student_ids))
            {
                MessageBox.Show(Messages.msgbox_Team_Added_Confirmation,
                                Messages.msgbox_universal_confirmation, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                new_team_added = true;
                this.Close();
                return;
            }
        }

        private void Form_Admin_Assign_Grades_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new_team_added == true)
                form_Student_Available_Projects.Refresh_Controls();
        }

        public void Create_Controls()
        {
            int previous_Add_Student_Button_LocationY = 0;
            int previous_Submit_Button_LocationY = 0;

            Control panel_Previous = utils.Find_Control(this.Controls, "panel_Student_" + (active_Student_Containers - 1));
            Panel panel_student = utils.add_Panel("panel_Student_" + active_Student_Containers,
                                                  panel_Previous.Width,
                                                  panel_Previous.Height,
                                                  panel_Previous.Location.X,
                                                  panel_Previous.Location.Y + panel_Previous.Height + 25);

            Label label_student_title = utils.add_Label("label_Student_Title_" + active_Student_Containers,
                                                        label_Student_1.Text,
                                                        label_Student_1.Width,
                                                        label_Student_1.Height,
                                                        label_Student_1.Location.X,
                                                        label_Student_1.Location.Y,
                                                        "MiddleRight",
                                                        true);

            Label label_student_name = utils.add_Label("label_Student_Name_" + active_Student_Containers,
                                                 label_Student_Name_1.Text,
                                                 label_Student_Name_1.Width,
                                                 label_Student_Name_1.Height,
                                                 label_Student_Name_1.Location.X,
                                                 label_Student_Name_1.Location.Y,
                                                 "MiddleRight",
                                                 false);
            TextBox textBox_name = utils.add_TextBox("textBox_Student_Name_" + active_Student_Containers,
                                                     textBox_Student_Name_1.Location.X,
                                                     textBox_Student_Name_1.Location.Y,
                                                     textBox_Student_Name_1.MaxLength,
                                                     false);

            Label label_student_surname = utils.add_Label("label_Student_Surname_" + active_Student_Containers,
                                                    label_Student_Surname_1.Text,
                                                    label_Student_Surname_1.Width,
                                                    label_Student_Surname_1.Height,
                                                    label_Student_Surname_1.Location.X,
                                                    label_Student_Surname_1.Location.Y,
                                                    "MiddleRight",
                                                    false);
            TextBox textBox_surname = utils.add_TextBox("textBox_Student_Surname_" + active_Student_Containers,
                                                        textBox_Student_Surname_1.Location.X,
                                                        textBox_Student_Surname_1.Location.Y,
                                                        textBox_Student_Surname_1.MaxLength,
                                                        false);

            Label label_student_am = utils.add_Label("label_AM_" + active_Student_Containers,
                                               label_AM_1.Text,
                                               label_AM_1.Width,
                                               label_AM_1.Height,
                                               label_AM_1.Location.X,
                                               label_AM_1.Location.Y,
                                               "MiddleRight",
                                               false);
            TextBox textBox_am = utils.add_TextBox("textBox_AM_" + active_Student_Containers,
                                                   textBox_Student_AM_1.Location.X,
                                                   textBox_Student_AM_1.Location.Y,
                                                   textBox_Student_AM_1.MaxLength,
                                                   false);

            Label label_student_email = utils.add_Label("label_Email_" + active_Student_Containers,
                                                  label_Email_1.Text,
                                                  label_Email_1.Width,
                                                  label_Email_1.Height,
                                                  label_Email_1.Location.X,
                                                  label_Email_1.Location.Y,
                                                  "MiddleRight",
                                                  false);
            TextBox textBox_email = utils.add_TextBox("textBox_Email_" + active_Student_Containers,
                                                      textBox_Student_Email_1.Location.X,
                                                      textBox_Student_Email_1.Location.Y,
                                                      textBox_Student_Email_1.MaxLength,
                                                      true);

            PictureBox pictureBox_Required_Name = utils.add_PictureBox("pictureBox_Required_Name_" + active_Student_Containers,
                                                                       pictureBox_Required_Name_1.Width,
                                                                       pictureBox_Required_Name_1.Height,
                                                                       pictureBox_Required_Name_1.Location.X,
                                                                       pictureBox_Required_Name_1.Location.Y);
            PictureBox pictureBox_Required_Surname = utils.add_PictureBox("pictureBox_Required_Surname_" + active_Student_Containers,
                                                                       pictureBox_Required_Surname_1.Width,
                                                                       pictureBox_Required_Surname_1.Height,
                                                                       pictureBox_Required_Surname_1.Location.X,
                                                                       pictureBox_Required_Surname_1.Location.Y);
            PictureBox pictureBox_Required_AM = utils.add_PictureBox("pictureBox_Required_AM_Name_" + active_Student_Containers,
                                                                     pictureBox_Required_AM_1.Width,
                                                                     pictureBox_Required_AM_1.Height,
                                                                     pictureBox_Required_AM_1.Location.X,
                                                                     pictureBox_Required_AM_1.Location.Y);
            PictureBox pictureBox_Required_Email = utils.add_PictureBox("pictureBox_Required_Email_Name_" + active_Student_Containers,
                                                                        pictureBox_Required_Email_1.Width,
                                                                        pictureBox_Required_Email_1.Height,
                                                                        pictureBox_Required_Email_1.Location.X,
                                                                        pictureBox_Required_Email_1.Location.Y);

            Button button_delete = utils.add_Button("button_Delete_Panel_" + active_Student_Containers,
                                                    7, 7, Messages.tooltip_button_delete_student_from_team);
            button_delete.ImageList = imageList_Buttons;
            button_delete.ImageIndex = 0;
            button_delete.Click += (s, e1) =>
            {
                button_Add_Student.Location = new Point(button_Add_Student.Location.X, previous_Add_Student_Button_LocationY);
                button_Submit_Team.Location = new Point(button_Submit_Team.Location.X, previous_Submit_Button_LocationY);

                panel_student.Dispose();

                active_Student_Containers--;
            };

            panel_Container.Controls.Add(panel_student);
            panel_student.Controls.Add(label_student_title);

            panel_student.Controls.Add(label_student_name);
            panel_student.Controls.Add(textBox_name);

            panel_student.Controls.Add(label_student_surname);
            panel_student.Controls.Add(textBox_surname);

            panel_student.Controls.Add(label_student_am);
            panel_student.Controls.Add(textBox_am);

            panel_student.Controls.Add(label_student_email);
            panel_student.Controls.Add(textBox_email);

            panel_student.Controls.Add(button_delete);

            panel_student.Controls.Add(pictureBox_Required_Name);
            panel_student.Controls.Add(pictureBox_Required_Surname);
            panel_student.Controls.Add(pictureBox_Required_AM);
            panel_student.Controls.Add(pictureBox_Required_Email);

            previous_Add_Student_Button_LocationY = button_Add_Student.Location.Y;
            previous_Submit_Button_LocationY = button_Submit_Team.Location.Y;
            button_Add_Student.Location = new Point(button_Add_Student.Location.X, panel_student.Location.Y + 286);
            button_Submit_Team.Location = new Point(button_Submit_Team.Location.X, button_Add_Student.Location.Y + 118);
        }

        private void button_Add_Student_Click(object sender, EventArgs e)
        {
            active_Student_Containers++;
            if (active_Student_Containers > max_project_students)
            {
                MessageBox.Show(Messages.msgbox_maximum_student_panels_error(max_project_students),
                                Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                active_Student_Containers--;
                return;
            }

            Create_Controls();
        }
    }
}