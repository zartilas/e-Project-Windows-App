using Npgsql;

namespace e_Projects.Classes
{
    internal class DatabaseChecks
    {
        public bool Check_Ιf_User_AM_Is_Registered(string student_am)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT * FROM USERS WHERE (STUDENT_REGISTRY_NUMBER = @student_am)";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("student_am", student_am);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read() == true)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool Check_If_User_Email_Is_Registered(string email)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT * FROM USERS WHERE (EMAIL = @email)";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("email", email);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read() == true)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool Check_If_User_AM_Exists_In_Another_Team(string student_AM, int project_ID)
        {
            var sql = "SELECT P.project_id, student_ids FROM PROJECTS P INNER JOIN TEAMS ON P.project_id = TEAMS.project_id " +
                      "WHERE P.project_id = @project_id AND TEAMS.student_ids LIKE @student_ids";

            using (NpgsqlConnection conn = (new DatabaseConnections()).Connect())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("project_id", project_ID);
                cmd.Parameters.AddWithValue("student_ids", "%" + student_AM + "%");
                cmd.Prepare();

                NpgsqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read() == true)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
        }
    }
}