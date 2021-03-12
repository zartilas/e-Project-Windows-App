using e_Projects.Classes;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms.Admin.Modify
{
    public partial class Form_Admin_Modify_User : Form
    {
        private int user_ID;
        private bool modified = false;
        private Form_Admin_Show_Users form_Admin_Show_Users = null;
        private Professor professor = new Professor();

        public Form_Admin_Modify_User(Form_Admin_Show_Users form_Admin_Show_Users, int user_ID)
        {
            InitializeComponent();
            this.form_Admin_Show_Users = form_Admin_Show_Users;
            this.user_ID = user_ID;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            textBox_AM.Text = professor.Get_User_AM(user_ID);
            textBox_FirstName.Text = professor.Get_User_First_Name(user_ID);
            textBox_LastName.Text = professor.Get_User_Last_Name(user_ID);
            textBox_Email.Text = professor.Get_User_Email(user_ID);
            string isAdmin = professor.Get_User_Is_Admin(user_ID);

            if (isAdmin == "True")
                radioButton_Yes.Checked = true;
            else
                radioButton_No.Checked = true;
        }

        private void Form_Admin_Assign_Grades_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (modified == true)
                form_Admin_Show_Users.Refresh_Controls();
        }

        private void button_Modify_Submit_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            if (professor.Update_User(user_ID, textBox_AM.Text, textBox_FirstName.Text, textBox_LastName.Text, textBox_Email.Text) == true)
            {
                DialogResult dialogResult = MessageBox.Show(Messages.msgbox_user_update_content,
                                                        Messages.msgbox_user_update_title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                form_Admin_Show_Users.Refresh_Controls();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(Messages.msgbox_user_update_content_error,
                                                            Messages.msgbox_universal_error_confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }
    }
}