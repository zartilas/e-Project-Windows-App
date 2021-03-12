using e_Projects.Classes;
using e_Projects.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace e_Projects
{
    public partial class FormMain : Form
    {
        private bool toggleRegister = false;
        private bool toggleLogin = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            toggleRegister = true;
            panel_Register.Visible = true;
            toggleLogin = false;
            panel_Login.Visible = false;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            toggleRegister = false;
            panel_Register.Visible = false;
            toggleLogin = true;
            panel_Login.Visible = true;
        }

        private void button_Register_Submit_Click(object sender, EventArgs e)
        {
            DatabaseChecks dbChecks = new DatabaseChecks();

            // Check if there are empty fields
            List<string> error_messages = new List<string>();
            if (textBox_Register_AM.Text == "" ||
                textBox_Register_Name.Text == "" ||
                textBox_Register_Surname.Text == "" ||
                textBox_Register_Email.Text == "" ||
                textBox_Register_Salt.Text == "")
            {
                error_messages.Add(Messages.error_message_empty_fields);
            }

            if (dbChecks.Check_Ιf_User_AM_Is_Registered(textBox_Register_AM.Text))
                error_messages.Add(Messages.error_message_reg_id_exists);

            if (dbChecks.Check_If_User_Email_Is_Registered(textBox_Register_Email.Text))
                error_messages.Add(Messages.error_message_email_exists);

            if (error_messages.Any())
            {
                var merge_messages = string.Join(Environment.NewLine, error_messages.ToArray());
                DialogResult result = MessageBox.Show(merge_messages,
                                                      Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            // Insert the user to the database
            DatabaseInsertions dbInsertions = new DatabaseInsertions();
            dbInsertions.Insert_User(textBox_Register_AM.Text.ToUpper().Replace("Π", "P"),
                                                 textBox_Register_Name.Text,
                                                 textBox_Register_Surname.Text,
                                                 textBox_Register_Email.Text,
                                                 textBox_Register_Salt.Text);

            MessageBox.Show(Messages.message_registration_completed,
                            "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Pass AM value to AM login textbox before clearing
            textBox_Login_AM.Text = textBox_Register_AM.Text;

            // Clear the previous fields since the registration is completed
            textBox_Register_AM.Clear();
            textBox_Register_Name.Clear();
            textBox_Register_Surname.Clear();
            textBox_Register_Email.Clear();
            textBox_Register_Salt.Clear();

            // Fire event to instantly switch to login "form".
            button_Login_Click(this, EventArgs.Empty);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);

            if (((TextBox)sender).Name == "textBox_Register_Name" ||
                ((TextBox)sender).Name == "textBox_Register_Surname")
            {
                if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }

            if (((TextBox)sender).Name == "textBox_Register_AM")
            {
                // allows only letters or numbers
                if (!char.IsLetterOrDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void button_Login_Submit_Click(object sender, EventArgs e)
        {
            // Check if there are empty fields
            if (textBox_Login_AM.Text == "" ||
                textBox_Login_Salt.Text == "")
            {
                MessageBox.Show(Messages.error_message_empty_fields, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User();

            if (!user.User_Authorization(textBox_Login_AM.Text.ToUpper().Replace("Π", "P"), textBox_Login_Salt.Text))
            {
                MessageBox.Show(Messages.error_message_login_credentials, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            if (user.Get_is_admin(textBox_Login_AM.Text.ToUpper()) == true)
            {
                var form_Admin_Menu = new Form_Admin_Menu(textBox_Login_AM.Text.ToUpper());
                form_Admin_Menu.Closed += (s, args) => this.Close();
                form_Admin_Menu.Show();
            }
            else
            {
                var form_Student_Menu = new Form_Student_Menu(textBox_Login_AM.Text.ToUpper());
                form_Student_Menu.Closed += (s, args) => this.Close();
                form_Student_Menu.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void textBox_Login_Salt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Login_Submit_Click(sender, e);
            }
        }
    }
}