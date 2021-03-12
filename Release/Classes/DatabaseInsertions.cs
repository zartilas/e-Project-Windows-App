using Npgsql;

namespace e_Projects.Classes
{
    internal class DatabaseInsertions
    {
        public void Insert_User(string am, string name, string surname, string email, string salt)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            // @something is a parameter
            var sql = "INSERT INTO USERS(STUDENT_REGISTRY_NUMBER, FIRST_NAME, LAST_NAME, EMAIL, SALT, ISADMIN) VALUES(@student_registry_id, @first_name, @last_name, @email, @salt, false)";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("student_registry_id", am);
            cmd.Parameters.AddWithValue("first_name", name);
            cmd.Parameters.AddWithValue("last_name", surname);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("salt", salt);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Correct_Seq_User_ID()
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT setval('users_user_id_seq', max(user_id)) FROM users;";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Correct_Seq_Project_ID()
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT setval('projects_project_id_seq', max(project_id)) FROM projects;";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Correct_Seq_Subject_ID()
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT setval('subjects_subject_id_seq', max(subject_id)) FROM subjects;";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Correct_Seq_Team_ID()
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT setval('teams_team_id_seq', max(team_id)) FROM teams;";
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}