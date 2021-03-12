using e_Projects.Classes;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms.Admin
{
    public partial class Form_Admin_Assign_Grade : Form
    {
        private int team_id;
        private int project_id;
        private Form_Admin_Show_Teams form_Admin_Show_Teams = null;
        private Professor professor = new Professor();

        public Form_Admin_Assign_Grade(int team_id, int project_id, Form_Admin_Show_Teams form_Admin_Show_Teams)
        {
            InitializeComponent();
            this.form_Admin_Show_Teams = form_Admin_Show_Teams;
            this.team_id = team_id;
            this.project_id = project_id;

            this.Text = "e-Projects | Καταχώριση Βαθμού Ομάδας " + team_id;
            label_Team_Title.Text = "Καταχώριση Βαθμού Ομάδας " + team_id;

            label_Max_Grade.Text += (int)(Int32.Parse(new Professor().Get_Project_Grade_Percentage(project_id).Replace("%", "")) * 0.1);
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        private void button_Submit_Grade_Click(object sender, EventArgs e)
        {
            int project_grade_percentage = (int)(Int32.Parse(professor.Get_Project_Grade_Percentage(project_id).Replace("%", "")) * 0.1);
            if (Int32.Parse(textBox_Grade.Text) > project_grade_percentage)
            {
                MessageBox.Show(Messages.msgbox_grade_input_error(project_grade_percentage.ToString()),
                    Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (professor.Set_Grade(team_id, Int32.Parse(textBox_Grade.Text)))
            {
                MessageBox.Show(Messages.msgbox_grade_assigned,
                    Messages.msgbox_universal_confirmation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MessageBox.Show(Messages.msgbox_grade_not_assigned_error,
                Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_Grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form_Admin_Assign_Grades_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBox_Grade.Text != "")
                form_Admin_Show_Teams.Refresh_Controls();
        }
    }
}