using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace e_Projects.Classes
{
    internal class Professor : User
    {
        public bool Insert_Assignment(String project_name, String subject_name, DateTime project_deadline,
            String project_grade_percentage, String project_desc, bool project_available)
        {
            DatabaseInsertions dbInsertions = new DatabaseInsertions();
            dbInsertions.Correct_Seq_Project_ID();
            var sql = "INSERT INTO PROJECTS(project_name, project_description, deadline, grade_percentage, project_available, subject_id) " +
                      "VALUES(@project_name, @project_description, @deadline , @grade_percentage, @project_available, @subject_id)";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("project_name", project_name);
                cmd.Parameters.AddWithValue("project_description", project_desc);
                cmd.Parameters.AddWithValue("deadline", SqlDbType.DateTime).Value = project_deadline;
                cmd.Parameters.AddWithValue("grade_percentage", project_grade_percentage);
                cmd.Parameters.AddWithValue("project_available", project_available);
                cmd.Parameters.AddWithValue("subject_id", Get_Subject_ID(subject_name));
                cmd.Prepare();

                int r = cmd.ExecuteNonQuery();

                conn.Close();

                if (r > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool Set_Grade(int team_id, int project_grade)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "UPDATE TEAMS " +
                      "SET grade = @project_grade " +
                      "WHERE TEAMS.team_id = @team_id";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("project_grade", project_grade);
            cmd.Parameters.AddWithValue("team_id", team_id);
            cmd.Prepare();

            int r = cmd.ExecuteNonQuery();

            conn.Close();
            return r > 0 ? true : false;
        }

        public bool Delete_Team(int team_id_)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "DELETE FROM TEAMS WHERE team_id = @t_id";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("t_id", team_id_);
            cmd.Prepare();

            // r will be 1 if the query is executed successfully, otherwise 0.
            int r = cmd.ExecuteNonQuery();

            conn.Close();

            return r > 0;
        }

        public bool Delete_Assignment(int project_id)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "DELETE FROM PROJECTS WHERE project_id = @project_id";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("project_id", project_id);
            cmd.Prepare();

            // r will be 1 if the query is executed successfully, otherwise 0.
            int r = cmd.ExecuteNonQuery();

            conn.Close();

            return r > 0;
        }

        public bool Delete_User(int user_id)
        {
            var sql = "DELETE FROM USERS WHERE user_id = @user_id";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("user_id", user_id);
                cmd.Prepare();
                // r will be 1 if the query is executed successfully, otherwise 0.
                int r = cmd.ExecuteNonQuery();

                conn.Close();

                return r > 0;
            }
        }

        public int Get_Subject_ID(String subject_name)
        {
            int subject_id = 0;

            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT subject_id FROM SUBJECTS WHERE subject_name = @subject_name";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("subject_name", subject_name);
            cmd.Prepare();

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                subject_id = (int)rdr["subject_id"];
            }
            conn.Close();
            return subject_id;
        }

        public string Get_User_AM(int user_ID)
        {
            var sql = "SELECT student_registry_number FROM USERS WHERE user_id = @user_id";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("user_id", user_ID);
                cmd.Prepare();

                NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string user_am = rdr["student_registry_number"].ToString();
                    conn.Close();
                    return user_am;
                }
                conn.Close();
                return null;
            }
        }

        public string Get_User_First_Name(int user_ID)
        {
            var sql = "SELECT first_name FROM USERS WHERE user_id = @user_id";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("user_id", user_ID);
                cmd.Prepare();

                NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string firstname = rdr["first_name"].ToString();
                    conn.Close();
                    return firstname;
                }
                conn.Close();
                return null;
            }
        }

        public string Get_User_Last_Name(int user_ID)
        {
            var sql = "SELECT last_name FROM USERS WHERE user_id = @user_id";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("user_id", user_ID);
                cmd.Prepare();

                NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string lastname = rdr["last_name"].ToString();
                    conn.Close();
                    return lastname;
                }
                conn.Close();
                return null;
            }
        }

        public string Get_User_Email(int user_ID)
        {
            var sql = "SELECT email FROM USERS WHERE user_id = @user_id";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("user_id", user_ID);
                cmd.Prepare();

                NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string email = rdr["email"].ToString();
                    conn.Close();
                    return email;
                }
                conn.Close();
                return null;
            }
        }

        public string Get_User_Is_Admin(int user_ID)
        {
            var sql = "SELECT isadmin FROM USERS WHERE user_id = @user_id";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("user_id", user_ID);
                cmd.Prepare();

                NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string isAdmin = rdr["isadmin"].ToString();
                    conn.Close();
                    return isAdmin;
                }
                conn.Close();
                return null;
            }
        }

        public bool Update_User(int user_ID, string user_AM, string first_Name, string last_Name, string email)
        {
            var sql = "UPDATE USERS SET student_registry_number = @user_am, first_name = @fname, last_name = @lname, email = @email " +
                      "WHERE user_id = @user_id";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("user_am", user_AM);
                cmd.Parameters.AddWithValue("fname", first_Name);
                cmd.Parameters.AddWithValue("lname", last_Name);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("user_id", user_ID);
                cmd.Prepare();

                int r = cmd.ExecuteNonQuery();

                conn.Close();

                if (r > 0)
                    return true;
                else
                    return false;
            }
        }

        public List<String> Get_Subject_Names()
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT subject_id, subject_name FROM SUBJECTS";
            var cmd = new NpgsqlCommand(sql, conn);

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            List<String> subject_names = new List<string>();
            while (rdr.Read())
            {
                subject_names.Add(rdr["subject_name"].ToString());
            }
            conn.Close();
            return subject_names;
        }

        public String Get_Project_Grade_Percentage(int project_id)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT grade_percentage FROM PROJECTS WHERE project_id = @project_id";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("project_id", project_id);

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            String grade_percentage = null;
            if (rdr.Read())
            {
                grade_percentage = rdr["grade_percentage"].ToString();
            }
            conn.Close();
            return grade_percentage;
        }

        public bool Save_ZIP_File(int project_id_, String student_ids)
        {
            Utilities utils = new Utilities();

            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT file " +
                      "FROM PROJECTS P " +
                      "INNER JOIN TEAMS ON P.project_id = TEAMS.project_id " +
                      "WHERE P.project_id = @project_id AND TEAMS.student_ids = @student_ids";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("project_id", project_id_);
            cmd.Parameters.AddWithValue("student_ids", student_ids);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            // Writes the BLOB to a file (*.bmp).
            FileStream stream;
            // Streams the BLOB to the FileStream object.
            BinaryWriter writer;

            // Size of the BLOB buffer.
            int bufferSize = 100;
            // The BLOB byte[] buffer to be filled by GetBytes.
            byte[] outByte = new byte[bufferSize];
            // The bytes returned from GetBytes.
            long retval;
            // The starting position in the BLOB output.
            long startIndex = 0;

            if (rdr.Read())
            {
                SaveFileDialog saveFileDialog = utils.Save_ZIP_File_Dialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    writer = new BinaryWriter(stream);
                    // Reset the starting byte for the new BLOB.
                    startIndex = 0;

                    // Read bytes into outByte[] and retain the number of bytes returned.
                    // 0 because file is in column[0] in the query result.
                    retval = rdr.GetBytes(0, startIndex, outByte, 0, bufferSize);

                    // Continue while there are bytes beyond the size of the buffer.
                    while (retval == bufferSize)
                    {
                        writer.Write(outByte);
                        writer.Flush();

                        // Reposition start index to end of last buffer and fill buffer.
                        startIndex += bufferSize;
                        retval = rdr.GetBytes(0, startIndex, outByte, 0, bufferSize);
                    }

                    // Write the remaining buffer.
                    writer.Write(outByte, 0, (int)retval);
                    writer.Flush();

                    // Close the output file.
                    writer.Close();
                    stream.Close();

                    rdr.Close();
                    conn.Close();
                    return true;
                }
            }
            rdr.Close();
            conn.Close();
            return false;
        }
    }
}