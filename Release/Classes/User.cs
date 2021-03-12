using Npgsql;
using System;
using System.Windows.Forms;

namespace e_Projects.Classes
{
    internal class User
    {
        private String am;
        private String email;
        private String first_name;
        private String last_name;
        private String salt;

        public void Logout(Form form)
        {
            form.Hide();
            var form_Main_Menu = new FormMain();
            form_Main_Menu.Closed += (s, args) => form.Close();
            form_Main_Menu.Show();
        }

        public bool User_Authorization(string user_am, string salt)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT * FROM USERS WHERE (STUDENT_REGISTRY_NUMBER = @am AND SALT = @salt)";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("am", user_am);
            cmd.Parameters.AddWithValue("salt", salt);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            // If the specific user exists
            if (rdr.Read() == true)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        // Getters
        public String Get_am()
        {
            return am;
        }

        public String Get_email()
        {
            return email;
        }

        public String Get_first_name()
        {
            return first_name;
        }

        public String Get_last_name()
        {
            return last_name;
        }

        public String Get_salt()
        {
            return salt;
        }

        public bool Get_is_admin(String am)
        {
            NpgsqlConnection conn = (new DatabaseConnections()).Connect();
            conn.Open();

            var sql = "SELECT * FROM USERS WHERE (STUDENT_REGISTRY_NUMBER = @am AND ISADMIN = true)";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("am", am);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            // If user is admin
            if (rdr.Read() == true)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        // Setters
        public void Set_am(String am)
        {
            this.am = am;
        }

        public void Set_email(String email)
        {
            this.email = email;
        }

        public void Set_first_name(String first_name)
        {
            this.first_name = first_name;
        }

        public void Set_last_name(String last_name)
        {
            this.last_name = last_name;
        }

        public void Set_salt(String salt)
        {
            this.salt = salt;
        }
    }
}