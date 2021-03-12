using e_Projects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace e_Projects.Forms.Admin
{
    public partial class Form_Admin_Add_Assignment : Form
    {
        private bool new_assignment_added = false;
        private Form_Admin_Show_Assignments form_Admin_Show_Assignments = null;
        private Professor professor = new Professor();

        public Form_Admin_Add_Assignment(Form_Admin_Show_Assignments form_Admin_Show_Assignments)
        {
            InitializeComponent();
            this.form_Admin_Show_Assignments = form_Admin_Show_Assignments;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // To allow only from today and so on
            dateTimePicker_Deadline.MinDate = DateTime.Now;

            List<String> all_subject_names = new Professor().Get_Subject_Names();
            if (!all_subject_names.Any())
            {
                comboBox_Subjects.Items.Add("-");
                comboBox_Subjects.Enabled = false;
                Utilities utils = new Utilities();
                utils.add_Tooltip(comboBox_Subjects, Messages.tooltip_no_subjects_available);
            }
            else
            {
                foreach (String subject in all_subject_names)
                {
                    comboBox_Subjects.Items.Add(subject);
                }
            }
        }

        private void button_Create_Assignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Description.Text) ||
                string.IsNullOrEmpty(textBox_Project_Name.Text) ||
                comboBox_Subjects.SelectedItem == null)
            {
                MessageBox.Show(Messages.error_message_empty_fields,
                                Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            bool radio_Button_Status = true;
            if (radioButton_No.Checked == true)
                radio_Button_Status = false;

            if (professor.Insert_Assignment(textBox_Project_Name.Text,
                                            comboBox_Subjects.SelectedItem.ToString(),
                                            dateTimePicker_Deadline.Value,
                                            numericUpDown_Percentage.Value + "%",
                                            textBox_Description.Text,
                                            radio_Button_Status))
            {
                new_assignment_added = true;
                MessageBox.Show(Messages.msgbox_insert_assignment_content,
                                Messages.msgbox_insert_assignment_title, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MessageBox.Show(Messages.msgbox_grade_not_assigned_error,
                            Messages.msgbox_universal_error_confirmation, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        private void Form_Admin_Assign_Grades_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new_assignment_added == true)
                form_Admin_Show_Assignments.Refresh_Controls();
        }

        private void textBox_Project_Name_TextChanged(object sender, EventArgs e)
        {
            label_Project_Name_Char_Limit.Text = "Αρ.Χαρακτήρων: " +
                                                 textBox_Project_Name.Text.Length +
                                                 "/" + textBox_Project_Name.MaxLength;
        }

        private void textBox_Description_TextChanged(object sender, EventArgs e)
        {
            label_Desc_Max_Char_Limit.Text = "Αρ.Χαρακτήρων: " +
                                             textBox_Description.Text.Length +
                                             "/" + textBox_Description.MaxLength;
        }
    }
}