using Npgsql;
using System;

namespace e_Projects.Classes
{
    internal class student : User
    {
        public bool Add_Team(int project_id, String student_ids)
        {
            DatabaseInsertions dbInsertions = new DatabaseInsertions();
            dbInsertions.Correct_Seq_Team_ID();
            var sql = "INSERT INTO TEAMS(project_id, student_ids, file_uploaded) " +
                      "VALUES(@project_id, @student_ids, file_uploaded = false)";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("project_id", project_id);
                cmd.Parameters.AddWithValue("student_ids", student_ids);
                cmd.Prepare();

                int r = cmd.ExecuteNonQuery();

                conn.Close();

                if (r > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool Get_File_Uploaded_Status(int project_id, String student_am)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * " +
                        "FROM PROJECTS P " +
                        "INNER JOIN TEAMS ON P.project_id = TEAMS.project_id " +
                        "WHERE P.project_id = @project_id AND TEAMS.student_ids LIKE @student_ids";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("project_id", project_id);
            cmd.Parameters.AddWithValue("student_ids", "%" + student_am + "%");

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if ((bool)rdr["file_uploaded"])
                {
                    return true;
                }
                conn.Close();
            }
            return false;
        }

        public String Get_Project_Grade(int project_id, String student_am)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * " +
                      "FROM PROJECTS P " +
                      "INNER JOIN TEAMS ON P.project_id = TEAMS.project_id " +
                      "WHERE P.project_id = @project_id AND TEAMS.student_ids LIKE @student_ids";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("project_id", project_id);
            cmd.Parameters.AddWithValue("student_ids", "%" + student_am + "%");

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                String grade = rdr["grade"].ToString();
                conn.Close();
                return grade;
            }
            return "";
        }

        public int Get_Project_Max_Students_Number(int project_id)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT P.max_students " +
                      "FROM PROJECTS P " +
                      "WHERE P.project_id = @project_id";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("project_id", project_id);

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                int max_students = (int)rdr["max_students"];
                conn.Close();
                return max_students;
            }
            conn.Close();
            return 0;
        }

        public int Get_Team_ID(int project_id, String student_am)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * " +
                      "FROM PROJECTS P " +
                      "INNER JOIN TEAMS ON P.project_id = TEAMS.project_id " +
                      "WHERE P.project_id = @project_id AND TEAMS.student_ids LIKE @student_ids";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("project_id", project_id);
            cmd.Parameters.AddWithValue("student_ids", "%" + student_am + "%");

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                int team_id = (int)rdr["team_id"];
                conn.Close();
                return team_id;
            }
            return 0;
        }

        public bool Check_If_User_Has_Project_Selected(int project_id, String student_am)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();
            var sql = "SELECT * " +
                        "FROM PROJECTS P " +
                        "INNER JOIN TEAMS ON P.project_id = TEAMS.project_id " +
                        "WHERE P.project_id = @project_id AND TEAMS.student_ids LIKE @student_ids AND P.project_available = true";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("project_id", project_id);
            cmd.Parameters.AddWithValue("student_ids", "%" + student_am + "%");

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                conn.Close();
                return true;
            }
            return false;
        }

        public bool Set_ZIP_File(byte[] zip_bytea, int team_id)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "UPDATE TEAMS " +
                      "SET file = @zip_file, file_uploaded = true, date_uploaded = current_timestamp " +
                      "WHERE team_id = @team_id";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("zip_file", zip_bytea);
            cmd.Parameters.AddWithValue("team_id", team_id);
            cmd.Prepare();

            // r will be 1 if the query is executed successfully, otherwise 0.
            int r = cmd.ExecuteNonQuery();

            conn.Close();

            return r > 0;
        }
    }
}