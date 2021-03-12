using e_Projects.Forms;
using e_Projects.Forms.Admin;
using e_Projects.Forms.Admin.Modify;
using e_Projects.Forms.Student;
using Npgsql;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace e_Projects.Classes
{
    internal class ControlsDesigner
    {
        Utilities utils = new Utilities();

        // ------------- ADMIN -------------
        public void Create_Users_Controls(Form_Admin_Show_Users form, Panel panel, ImageList imageList, string current_user_am,
            int pos_user_id, int pos_user_am, int pos_fname, int pos_lname, int pos_email, int pos_isadmin, int pos_actions)
        {
            var sql = "SELECT * FROM USERS WHERE student_registry_number NOT IN (@user_am)";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("user_am", current_user_am);
                cmd.Prepare();

                NpgsqlDataReader rdr = cmd.ExecuteReader();

                Professor professor = new Professor();

                int posY = 10;
                while (rdr.Read())
                {
                    int user_Id = (int)rdr["user_id"];
                    string user_Am = (string)rdr["student_registry_number"];
                    string first_Name = (string)rdr["first_name"];
                    string last_Name = (string)rdr["last_name"];
                    string email = (string)rdr["email"];
                    string is_Admin = rdr["isadmin"].ToString().Replace("True", Messages.msg_yes).Replace("False", Messages.msg_no);

                    Label label_user_id = utils.add_Label("label_User_ID_" + user_Id,
                                                          user_Id.ToString(),
                                                          pos_user_id,
                                                          posY);

                    Label label_user_am = utils.add_Label("label_User_AM_" + user_Id,
                                                          user_Am,
                                                          pos_user_am,
                                                          posY);

                    Label label_firstname = utils.add_Label("label_User_FirstName_" + user_Id,
                                                            first_Name,
                                                            pos_fname,
                                                            posY);

                    Label label_lastname = utils.add_Label("label_User_LastName_" + user_Id,
                                                           last_Name,
                                                           pos_lname,
                                                           posY);

                    Label label_email = utils.add_Label("label_User_Email_" + user_Id,
                                                        email,
                                                        pos_email,
                                                        posY);

                    Label label_isadmin = utils.add_Label("label_User_IsAdmin_" + user_Id,
                                                          is_Admin,
                                                          pos_isadmin,
                                                          posY);

                    // Actions
                    Panel panel_Actions = utils.add_Actions_Panel("panel_Actions_" + user_Id,
                                                                  72,
                                                                  pos_actions,
                                                                  posY);

                    Button button_Update = utils.add_Button(user_Id.ToString(),
                                                            2, 0,
                                                            Messages.tooltip_button_modify_user);
                    button_Update.ImageList = imageList;
                    button_Update.ImageIndex = 4;
                    button_Update.Click += (s, e) =>
                    {
                        Form_Admin_Modify_User form_Modify_User = new Form_Admin_Modify_User(form, user_Id);
                        form_Modify_User.ShowDialog();
                    };
                    Button button_Delete = utils.add_Button(user_Id.ToString(),
                                                            35, 0,
                                                            Messages.tooltip_button_delete_user);
                    button_Delete.ImageList = imageList;
                    button_Delete.ImageIndex = 3;
                    button_Delete.Click += (s, e) =>
                    {
                        DialogResult dialogResult = MessageBox.Show(Messages.msgbox_delete_user_content,
                            Messages.msgbox_delete_user_title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            professor.Delete_User(Int32.Parse(button_Delete.Name));
                            form.Refresh_Controls();
                        }
                    };

                    panel.Controls.Add(label_user_id);
                    panel.Controls.Add(label_user_am);
                    panel.Controls.Add(label_firstname);
                    panel.Controls.Add(label_lastname);
                    panel.Controls.Add(label_email);
                    panel.Controls.Add(label_isadmin);
                    panel.Controls.Add(panel_Actions);
                    panel_Actions.Controls.Add(button_Update);
                    panel_Actions.Controls.Add(button_Delete);

                    posY += 50;
                }
                conn.Close();
            }
        }

        public void Create_Show_Assignments_Controls(Form_Admin_Show_Assignments form, Panel panel, ImageList imageList,
            int pos_project_id, int pos_project_name, int pos_project_desc, int pos_deadline, int pos_grade_perc, int pos_actions)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * FROM PROJECTS ORDER BY subject_id ASC";
            var cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();


            Professor professor = new Professor();

            int posY = 10;
            while (rdr.Read())
            {
                int project_id = (int)rdr["project_id"];
                String project_name = rdr["project_name"].ToString();
                String project_desc = rdr["project_description"].ToString();
                String project_deadline = rdr["deadline"].ToString();
                String project_grade_percentage = rdr["grade_percentage"].ToString();

                Label label_project_id = utils.add_Label("label_Project_ID_" + project_id,
                                                         project_id.ToString(),
                                                         pos_project_id,
                                                         posY);

                Label label_project_name = utils.add_Label("label_Project_Name_" + project_id,
                                                           project_name,
                                                           pos_project_name,
                                                           posY);

                Button button_project_description = utils.add_Button("button_Project_Desc_" + project_id,
                                                                     pos_project_desc,
                                                                     posY,
                                                                     Messages.tooltip_button_project_desc);
                button_project_description.ImageList = imageList;
                button_project_description.ImageIndex = 3;
                button_project_description.Click += (s, e) =>
                {
                    Form_Admin_Show_Assignment_Description form_View_Description = new Form_Admin_Show_Assignment_Description(project_name, project_desc);
                    form_View_Description.ShowDialog();
                };

                Label label_deadline = utils.add_Label("label_Project_Deadline_" + project_id,
                                                       project_deadline,
                                                       pos_deadline,
                                                       posY);

                Label label_grade_percentage = utils.add_Label("label_Project_Deadline_" + project_id,
                                                               project_grade_percentage,
                                                               pos_grade_perc,
                                                               posY);

                Panel panel_Actions = utils.add_Actions_Panel("panel_Actions_" + project_id,
                                                              36,
                                                              pos_actions,
                                                              posY);

                Button button_Delete_Assignment = utils.add_Button("button_Delete_" + project_id,
                                                        4, 0,
                                                        Messages.tooltip_button_delete_assignment);
                button_Delete_Assignment.ImageList = imageList;
                button_Delete_Assignment.ImageIndex = 4;
                button_Delete_Assignment.Click += (s, e) =>
                {
                    DialogResult dialogResult = MessageBox.Show(Messages.msgbox_delete_assignment_content,
                                                                Messages.msgbox_delete_assignment_title,
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        professor.Delete_Assignment(project_id);
                        form.Refresh_Controls();
                    }
                };

                panel.Controls.Add(label_project_id);
                panel.Controls.Add(label_project_name);
                panel.Controls.Add(button_project_description);
                panel.Controls.Add(label_deadline);
                panel.Controls.Add(label_grade_percentage);
                panel.Controls.Add(panel_Actions);
                panel_Actions.Controls.Add(button_Delete_Assignment);
                posY += 50;
            }
            conn.Close();
        }

        public void Create_Teams_Controls(Form_Admin_Show_Teams form, Panel panel, ImageList imageList,
            int pos_team_id, int pos_project_id, int pos_student_ids, int pos_file,
            int pos_file_upload_status, int pos_file_uploaded_date, int pos_grade, int pos_actions)
        {

            Professor professor = new Professor();

            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * FROM TEAMS " +
                      "INNER JOIN projects ON " +
                      "teams.project_id = projects.project_id " +
                      "ORDER BY date_uploaded DESC NULLS LAST";
            var cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            int posY = 10;
            while (rdr.Read())
            {
                int team_id = (int)rdr["team_id"];
                int project_id = (int)rdr["project_id"];
                String student_ids = rdr["student_ids"].ToString();
                String file = rdr["file"].ToString();
                String file_upload_status = rdr["file_uploaded"].ToString();
                String grade = rdr["grade"].ToString();
                String file_Uploaded_Date = rdr["date_uploaded"].ToString();

                Label label_team_id = utils.add_Label("label_Team_ID_" + team_id,
                                                      team_id.ToString(),
                                                      pos_team_id,
                                                      posY);

                Button button_project_desc = utils.add_Button("button_Students_Info_" + team_id,
                                                              pos_project_id,
                                                              posY,
                                                              Messages.tooltip_button_project_desc);
                button_project_desc.ImageList = imageList;
                button_project_desc.ImageIndex = 3;
                button_project_desc.Click += (s, e) =>
                {
                    Form_Admin_Show_Team_Project_Info form_View_Project_Info = new Form_Admin_Show_Team_Project_Info(project_id);
                    form_View_Project_Info.ShowDialog();
                };

                Label label_project_id = utils.add_Label("label_Project_ID_" + team_id,
                                                         project_id.ToString(),
                                                         pos_project_id + 30,
                                                         posY);

                Button button_students_Info = utils.add_Button("button_Students_Info_" + team_id,
                                                               pos_student_ids,
                                                               posY,
                                                               Messages.tooltip_button_more_info);

                button_students_Info.ImageList = imageList;
                button_students_Info.ImageIndex = 3;
                button_students_Info.Click += (s, e) =>
                {
                    Form_Admin_Show_Team_Students_Info form_View_Students_Info = new Form_Admin_Show_Team_Students_Info(student_ids);
                    form_View_Students_Info.ShowDialog();
                };

                Label label_student_ids = utils.add_Label("label_Student_IDs_" + team_id,
                                                          student_ids,
                                                          pos_student_ids + 30,
                                                          posY);

                Button button_file_zip = utils.add_Button("button_File_ZIP_" + team_id,
                                                          pos_file,
                                                          posY);

                Label label_file_date_uploaded = utils.add_Label("label_File_Date_Uploaded_" + team_id,
                                                                 file_Uploaded_Date,
                                                                 pos_file_uploaded_date,
                                                                 posY);

                if (!string.IsNullOrEmpty(file))
                {
                    button_file_zip.ImageList = imageList;
                    button_file_zip.ImageIndex = 4;
                    ToolTip tooltip_Button_File_ZIP = new ToolTip();
                    tooltip_Button_File_ZIP.SetToolTip(button_file_zip, Messages.tooltip_button_download_zip);
                    button_file_zip.Click += (s, e) =>
                    {
                        if (professor.Save_ZIP_File(project_id, student_ids))
                            MessageBox.Show(Messages.msgbox_file_saved_content, Messages.msgbox_file_saved_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };
                }
                else
                {
                    button_file_zip.Text = "-";
                    button_file_zip.Cursor = Cursors.Default;
                    label_file_date_uploaded.Text = "-";
                }

                Label label_file_upload_status = utils.add_Label("label_File_Upload_Status_" + team_id,
                                                                 file_upload_status
                                                                 .Replace("True", Messages.msg_yes)
                                                                 .Replace("False", Messages.msg_no),
                                                                 pos_file_upload_status,
                                                                 posY);

                Label label_grade = utils.add_Label("label_Grade_" + team_id,
                                                    grade,
                                                    pos_grade,
                                                    posY);

                if (string.IsNullOrEmpty(label_grade.Text))
                    label_grade.Text = "-";

                // Actions
                Panel panel_Actions = utils.add_Actions_Panel("panel_Actions_" + team_id,
                                                              72,
                                                              pos_actions,
                                                              posY);

                Button button_Set_Grade = utils.add_Button("button_Set_Grade_" + team_id,
                                                          4, 0,
                                                          Messages.tooltip_button_set_grade);
                button_Set_Grade.ImageList = imageList;
                button_Set_Grade.ImageIndex = 6;
                button_Set_Grade.Click += (s, e) =>
                {
                    Form_Admin_Assign_Grade form_Assign_Grades = new Form_Admin_Assign_Grade(team_id, project_id, form);
                    form_Assign_Grades.ShowDialog();
                };

                Button button_Delete = utils.add_Button(team_id.ToString(),
                                                        35, 0,
                                                        Messages.tooltip_button_delete_team);
                button_Delete.ImageList = imageList;
                button_Delete.ImageIndex = 5;
                button_Delete.Click += (s, e) =>
                {
                    DialogResult dialogResult = MessageBox.Show(Messages.msgbox_delete_team_content,
                        Messages.msgbox_delete_team_title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        professor.Delete_Team(Int32.Parse(button_Delete.Name));
                        form.Refresh_Controls();
                    }
                };

                panel.Controls.Add(label_team_id);
                panel.Controls.Add(button_project_desc);
                panel.Controls.Add(label_project_id);
                panel.Controls.Add(button_students_Info);
                panel.Controls.Add(label_student_ids);
                panel.Controls.Add(button_file_zip);
                panel.Controls.Add(label_file_upload_status);
                panel.Controls.Add(label_file_date_uploaded);
                panel.Controls.Add(label_grade);
                panel.Controls.Add(panel_Actions);
                panel_Actions.Controls.Add(button_Delete);
                panel_Actions.Controls.Add(button_Set_Grade);
                posY += 50;
            }
            conn.Close();
        }

        public void Create_Project_Info_Controls(Form form, Panel panel, ImageList imageList, int project_id_)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * FROM PROJECTS WHERE PROJECT_ID=@P_ID";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("P_ID", project_id_);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                Label project_id = new Label();
                Label project_name = new Label();
                Button project_description = new Button();
                Label deadline = new Label();
                Label grade_percentage = new Label();

                int pos = 111;
                project_id.Location = new Point(10, pos);
                project_name.Location = new Point(139, pos);
                deadline.Location = new Point(776, pos);
                grade_percentage.Location = new Point(1017, pos);

                // Label Names
                project_id.Name = rdr["project_id"] + "_Project_ID_Label";
                project_name.Name = rdr["project_id"] + "_Project_Name_Label";
                deadline.Name = rdr["project_id"] + "_Deadline_Label";
                grade_percentage.Name = rdr["project_id"] + "_Grade_Percent_Label";

                project_id.Text = rdr["project_id"].ToString();
                project_name.Text = rdr["project_name"].ToString();
                deadline.Text = rdr["deadline"].ToString();
                grade_percentage.Text = rdr["grade_percentage"].ToString();
                String desc_contents = rdr["project_description"].ToString();

                project_id.AutoSize = true;
                project_name.AutoSize = true;
                deadline.AutoSize = true;
                grade_percentage.AutoSize = true;

                // Desc View Properties
                project_description.Name = rdr["project_id"].ToString();
                project_description.Text = "";
                project_description.AutoSize = true;
                project_description.BackColor = Color.Transparent;
                project_description.FlatStyle = FlatStyle.Flat;
                project_description.FlatAppearance.BorderSize = 0;
                project_description.FlatAppearance.MouseDownBackColor = Color.Transparent;
                project_description.FlatAppearance.MouseOverBackColor = Color.Transparent;
                project_description.ImageList = imageList;
                project_description.ImageIndex = 3;
                ToolTip tooltip_Button_Project_Description = new ToolTip();
                tooltip_Button_Project_Description.SetToolTip(project_description, "Περιγραφή");
                project_description.Size = new Size(27, 22);
                project_description.Location = new Point(615, pos);
                project_description.Cursor = Cursors.Hand;
                project_description.Click += (s, e) =>
                {
                    Form_Admin_Show_Assignment_Description form_view_desc = new Form_Admin_Show_Assignment_Description(project_name.Text, desc_contents);
                    form_view_desc.ShowDialog();
                };

                panel.Controls.Add(project_id);
                panel.Controls.Add(project_name);
                panel.Controls.Add(project_description);
                panel.Controls.Add(deadline);
                panel.Controls.Add(grade_percentage);
                conn.Close();
            }
        }

        public void Create_Students_Info_Controls(Form form, Panel panel, String student_ids_)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();

            int pos = 111;
            String[] temp_student_ids = student_ids_.Split(',');
            for (int i = 0; i < temp_student_ids.Length; i++)
            {
                conn.Open();
                var sql = "SELECT * FROM USERS WHERE USERS.student_registry_number = @student_reg_number;";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("student_reg_number", temp_student_ids[i].Trim());
                NpgsqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    Label user_id = new Label();
                    Label student_id = new Label();
                    Label firstname = new Label();
                    Label lastname = new Label();
                    Label email = new Label();

                    user_id.Location = new Point(10, pos);
                    student_id.Location = new Point(110, pos);
                    firstname.Location = new Point(305, pos);
                    lastname.Location = new Point(475, pos);
                    email.Location = new Point(669, pos);

                    // Label Names
                    user_id.Name = rdr["student_registry_number"] + "_User_ID_Label";
                    student_id.Name = rdr["student_registry_number"] + "_Student_Registry_Number_Label";
                    firstname.Name = rdr["student_registry_number"] + "_First_Name_Label";
                    lastname.Name = rdr["student_registry_number"] + "_Last_Name_Label";
                    email.Name = rdr["student_registry_number"] + "_Email_Label";

                    user_id.Text = rdr["user_id"].ToString();
                    student_id.Text = rdr["student_registry_number"].ToString();
                    firstname.Text = rdr["first_name"].ToString();
                    lastname.Text = rdr["last_name"].ToString();
                    email.Text = rdr["email"].ToString();

                    user_id.AutoSize = true;
                    student_id.AutoSize = true;
                    firstname.AutoSize = true;
                    lastname.AutoSize = true;
                    email.AutoSize = true;

                    panel.Controls.Add(user_id);
                    panel.Controls.Add(student_id);
                    panel.Controls.Add(firstname);
                    panel.Controls.Add(lastname);
                    panel.Controls.Add(email);
                    pos += 50;
                }
                conn.Close();
            }
        }

        // ------------- STUDENT -------------
        public void Create_Available_Projects_Controls(Form_Student_Available_Projects form, Panel panel, ImageList imageList, string student_am,
            int pos_pr_name, int pos_pr_desc, int pos_pr_deadline, int pos_pr_grade_perc, int pos_pr_choosen, int pos_pr_actions, int pos_pr_uploaded)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * FROM PROJECTS WHERE project_available = true";
            var cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            student student = new student();

            int posY = 50; int start_num = 1;
            while (rdr.Read())
            {
                int project_id = (int)rdr["project_id"];
                String project_description = rdr["project_description"].ToString();
                String project_name = rdr["project_name"].ToString();
                String project_deadline = rdr["deadline"].ToString();
                String project_grade_percentage = rdr["grade_percentage"].ToString();

                Label label_numbering = utils.add_Numbering_Label(start_num, 10, posY);

                Label label_name = utils.add_Label("label_Project_Name_" + project_id,
                                                  project_name,
                                                  pos_pr_name,
                                                  posY);

                Button button_desc = utils.add_Button("button_Desc_" + project_id,
                                                     pos_pr_desc,
                                                     posY,
                                                     Messages.tooltip_button_project_desc);
                button_desc.ImageList = imageList;
                button_desc.ImageIndex = 3;
                button_desc.Click += (s, e) =>
                {
                    Form_Student_Project_View_Description form_View_Description = new Form_Student_Project_View_Description(label_name.Text, project_description);
                    form_View_Description.ShowDialog();
                };

                Label label_deadline = utils.add_Label("label_Deadline_" + project_id,
                                                      project_deadline,
                                                      pos_pr_deadline,
                                                      posY);

                Label label_grade_perc = utils.add_Label("label_Grade_Percentage_" + project_id,
                                                        project_grade_percentage,
                                                        pos_pr_grade_perc,
                                                        posY);

                Panel panel_actions = utils.add_Actions_Panel("panel_Actions_" + project_id,
                                                             36,
                                                             pos_pr_actions,
                                                             posY);

                String file_uploaded_status = Messages.msg_no;
                String choosen_project_status = Messages.msg_no;
                if (student.Check_If_User_Has_Project_Selected(project_id, student_am))
                {
                    choosen_project_status = Messages.msg_yes;

                    Button button_action_upload_file = utils.add_Button("button_Upload_File_" + rdr["project_id"], 4, 0,
                                                                        Messages.tooltip_button_upload_file);
                    button_action_upload_file.ImageList = imageList;

                    ToolTip toolTip = new ToolTip();
                    if (student.Get_File_Uploaded_Status((int)rdr["project_id"], student_am))
                    {
                        file_uploaded_status = Messages.msg_yes;
                        button_action_upload_file.ImageIndex = 6;
                        toolTip.SetToolTip(button_action_upload_file, Messages.tooltip_button_file_already_uploaded);
                    }
                    else
                    {
                        button_action_upload_file.ImageIndex = 5;
                    }
                    button_action_upload_file.Click += (s, e) =>
                    {
                        OpenFileDialog openFileDialog = utils.Open_ZIP_File_Dialog();
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            byte[] zip_bytea = File.ReadAllBytes(openFileDialog.FileName);
                            student.Set_ZIP_File(zip_bytea, student.Get_Team_ID(project_id, student_am));
                            MessageBox.Show(Messages.msgbox_file_uploaded_content, Messages.msgbox_file_uploaded_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.Refresh();
                        }
                    };
                    panel_actions.Controls.Add(button_action_upload_file);
                }
                else
                {
                    Button button_action_add_team = utils.add_Button("button_Add_Team_" + rdr["project_id"], 4, 0,
                                                                    Messages.tooltip_button_add_team);
                    button_action_add_team.ImageList = imageList;
                    button_action_add_team.ImageIndex = 4;
                    button_action_add_team.Click += (s, e) =>
                    {
                        Form_Student_Project_Add_Team form_Add_Team = new Form_Student_Project_Add_Team(form, project_id);
                        form_Add_Team.ShowDialog();
                    };

                    panel.Controls.Add(panel_actions);
                    panel_actions.Controls.Add(button_action_add_team);
                }
                Label label_choosen = utils.add_Label("label_Choosen_" + rdr["project_id"],
                                                     choosen_project_status,
                                                     pos_pr_choosen,
                                                     posY);

                Label label_file_uploaded = utils.add_Label("label_File_Uploaded_" + rdr["project_id"],
                                                         file_uploaded_status,
                                                         pos_pr_uploaded,
                                                         posY);

                panel.Controls.Add(label_numbering);
                panel.Controls.Add(label_name);
                panel.Controls.Add(button_desc);
                panel.Controls.Add(label_deadline);
                panel.Controls.Add(label_grade_perc);
                panel.Controls.Add(label_choosen);
                panel.Controls.Add(label_file_uploaded);
                panel.Controls.Add(panel_actions);

                posY += 50;
                start_num++;
            }
            conn.Close();
        }

        public void Create_My_Projects_Controls(Form form, Panel panel, ImageList imageList, string student_am,
            int pos_pr_name, int pos_pr_desc, int pos_pr_deadline, int pos_pr_grade_perc, int pos_pr_actions, int pos_pr_uploaded, int pos_grade)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * FROM PROJECTS WHERE project_available = true";
            var cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();


            student student = new student();

            int posY = 50; int start_num = 1;
            while (rdr.Read())
            {
                int project_id = (int)rdr["project_id"];
                String project_description = rdr["project_description"].ToString();
                String project_name = rdr["project_name"].ToString();
                String project_deadline = rdr["deadline"].ToString();
                String project_grade_percentage = rdr["grade_percentage"].ToString();
                String project_grade = student.Get_Project_Grade(project_id, student_am);
                bool project_availability = (bool)rdr["project_available"];

                if (student.Check_If_User_Has_Project_Selected(project_id, student_am))
                {
                    Label label_numbering = utils.add_Numbering_Label(start_num, 10, posY);

                    Label label_name = utils.add_Label("label_Project_Name_" + project_id,
                                                      project_name,
                                                      pos_pr_name,
                                                      posY);

                    Button button_desc = utils.add_Button("button_Desc_" + project_id,
                                                         pos_pr_desc,
                                                         posY,
                                                         Messages.tooltip_button_project_desc);
                    button_desc.ImageList = imageList;
                    button_desc.ImageIndex = 3;
                    button_desc.Click += (s, e) =>
                    {
                        Form_Student_Project_View_Description form_view_desc = new Form_Student_Project_View_Description(label_name.Text, project_description);
                        form_view_desc.ShowDialog();
                    };

                    Label label_deadline = utils.add_Label("label_Deadline_" + project_id,
                                                          project_deadline,
                                                          pos_pr_deadline,
                                                          posY);

                    Label label_grade_perc = utils.add_Label("label_Grade_Percentage_" + project_id,
                                                            project_grade_percentage,
                                                            pos_pr_grade_perc,
                                                            posY);

                    Label label_project_grade = utils.add_Label("label_Project_Grade_" + project_id,
                                                               project_grade,
                                                               pos_grade,
                                                               posY);

                    Label label_file_uploaded = utils.add_Label("label_File_Uploaded_" + project_id,
                                                               Messages.msg_no,
                                                               pos_pr_uploaded,
                                                               posY);
                    if (student.Get_File_Uploaded_Status(project_id, student_am))
                        label_file_uploaded.Text = Messages.msg_yes;

                    if (project_availability == true)
                    {
                        if (string.IsNullOrEmpty(label_project_grade.Text))
                            label_project_grade.Text = "-";

                        Panel panel_actions = utils.add_Actions_Panel("panel_Actions_" + project_id,
                                                                     36,
                                                                     pos_pr_actions,
                                                                     posY);

                        Button button_action_upload_file = utils.add_Button("button_Upload_File_" + project_id, 4, 0,
                                                                            Messages.tooltip_button_upload_file);
                        button_action_upload_file.ImageList = imageList;

                        ToolTip toolTip = new ToolTip();
                        if (label_file_uploaded.Text == Messages.msg_yes)
                        {
                            button_action_upload_file.ImageIndex = 5;
                            toolTip.SetToolTip(button_action_upload_file, Messages.tooltip_button_file_already_uploaded);
                        }
                        else
                        {
                            button_action_upload_file.ImageIndex = 4;
                        }
                        button_action_upload_file.Click += (s, e) =>
                        {
                            OpenFileDialog openFileDialog = utils.Open_ZIP_File_Dialog();
                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                byte[] zip_bytea = File.ReadAllBytes(openFileDialog.FileName);
                                student.Set_ZIP_File(zip_bytea, student.Get_Team_ID(project_id, student_am));
                                MessageBox.Show(Messages.msgbox_file_uploaded_content, Messages.msgbox_file_uploaded_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.Refresh();
                            }
                        };

                        panel.Controls.Add(panel_actions);
                        panel_actions.Controls.Add(button_action_upload_file);
                    }
                    else
                    {
                        Label label_actions = utils.add_Label("label_Actions_" + project_id,
                                                             "-",
                                                             pos_pr_actions,
                                                             posY);
                        panel.Controls.Add(label_actions);
                    }

                    panel.Controls.Add(label_numbering);
                    panel.Controls.Add(label_name);
                    panel.Controls.Add(button_desc);
                    panel.Controls.Add(label_deadline);
                    panel.Controls.Add(label_grade_perc);
                    panel.Controls.Add(label_file_uploaded);
                    panel.Controls.Add(label_project_grade);

                    posY += 50;
                    start_num++;
                }
            }
            conn.Close();
        }

        public void Create_My_Project_Grades_Controls(Form form, Panel panel_Grades, ImageList imageList, string student_am,
                int pos_pr_name, int pos_pr_desc, int pos_pr_deadline, int pos_pr_grade_perc, int pos_pr_uploaded, int pos_pr_status, int pos_pr_grade)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * FROM PROJECTS " +
                      "ORDER BY subject_id ASC, deadline DESC";
            var cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();


            student student = new student();

            int posY = 50; int start_num = 1;
            while (rdr.Read())
            {
                int project_id = (int)rdr["project_id"];
                String project_description = rdr["project_description"].ToString();
                String project_name = rdr["project_name"].ToString();
                String project_deadline = rdr["deadline"].ToString();
                String project_grade_percentage = rdr["grade_percentage"].ToString();
                bool project_status = (bool)rdr["project_available"];

                if (student.Check_If_User_Has_Project_Selected(project_id, student_am))
                {
                    Label label_numbering = utils.add_Numbering_Label(start_num, 10, posY);

                    Label label_name = utils.add_Label("label_Project_Name_" + project_id,
                                                      project_name,
                                                      pos_pr_name,
                                                      posY);

                    Button button_desc = utils.add_Button("button_Desc_" + project_id,
                                                         pos_pr_desc,
                                                         posY,
                                                         Messages.tooltip_button_project_desc);
                    button_desc.ImageList = imageList;
                    button_desc.ImageIndex = 3;
                    button_desc.Click += (s, e) =>
                    {
                        Form_Student_Project_View_Description form_View_Description = new Form_Student_Project_View_Description(label_name.Text, project_description);
                        form_View_Description.ShowDialog();
                    };

                    Label label_deadline = utils.add_Label("label_Deadline_" + project_id,
                                                          project_deadline,
                                                          pos_pr_deadline,
                                                          posY);

                    Label label_grade_perc = utils.add_Label("label_Grade_Percentage_" + project_id,
                                                            project_grade_percentage,
                                                            pos_pr_grade_perc,
                                                            posY);

                    Label label_file_uploaded = utils.add_Label("label_File_Uploaded_" + project_id,
                                                               student.Get_File_Uploaded_Status(project_id, student_am).ToString()
                                                               .Replace("True", Messages.msg_yes)
                                                               .Replace("False", Messages.msg_no),
                                                               pos_pr_uploaded,
                                                               posY);

                    Label label_project_status = utils.add_Label("label_Project_Status_" + project_id,
                                                               project_status.ToString()
                                                               .Replace("True", Messages.msg_status_active)
                                                               .Replace("False", Messages.msg_status_inactive),
                                                               pos_pr_status,
                                                               posY);

                    String project_grade = student.Get_Project_Grade(project_id, student_am);
                    if (string.IsNullOrEmpty(project_grade))
                        project_grade = "-";

                    Label label_project_grade = utils.add_Label("label_File_Uploaded_" + project_id,
                                                               project_grade,
                                                               pos_pr_grade,
                                                               posY);

                    panel_Grades.Controls.Add(label_numbering);
                    panel_Grades.Controls.Add(label_name);
                    panel_Grades.Controls.Add(button_desc);
                    panel_Grades.Controls.Add(label_deadline);
                    panel_Grades.Controls.Add(label_grade_perc);
                    panel_Grades.Controls.Add(label_file_uploaded);
                    panel_Grades.Controls.Add(label_project_status);
                    panel_Grades.Controls.Add(label_project_grade);
                    posY += 50;
                    start_num++;
                }
            }
            conn.Close();
        }

        public void Create_My_Subject_Grades_Controls(Form form, Panel panel_Subjects, ImageList imageList, string student_am,
                int pos_sub_name, int pos_sub_grade)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT SUBJECTS.subject_name, SUM(TEAMS.grade) AS SUBJECT_GRADE FROM PROJECTS P " +
                      "INNER JOIN TEAMS ON P.project_id = TEAMS.project_id " +
                      "INNER JOIN SUBJECTS ON P.subject_id = SUBJECTS.subject_id " +
                      "WHERE TEAMS.student_ids LIKE @student_am " +
                      "GROUP BY SUBJECTS.subject_name";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("student_am", "%" + student_am + "%");

            NpgsqlDataReader rdr = cmd.ExecuteReader();


            student student = new student();

            int posY = 50; int start_num = 1;
            while (rdr.Read())
            {
                String subject_name = rdr["subject_name"].ToString();
                String subject_grade = rdr["subject_grade"].ToString();

                if (subject_grade != "")
                {
                    Label label_numbering = utils.add_Numbering_Label(start_num, 10, posY);

                    Label label_subject_name = utils.add_Label("label_Subject_Name_" + start_num,
                                                               subject_name,
                                                               pos_sub_name,
                                                               posY);

                    Label label_subject_grade = utils.add_Label("label_Subject_Grade_" + start_num,
                                                               subject_grade + "/10",
                                                               pos_sub_grade,
                                                               posY);

                    panel_Subjects.Controls.Add(label_numbering);
                    panel_Subjects.Controls.Add(label_subject_name);
                    panel_Subjects.Controls.Add(label_subject_grade);
                    posY += 50;
                    start_num++;
                }
            }
            conn.Close();
        }
    }
}