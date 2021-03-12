using Npgsql;
using System;

namespace e_Projects.Classes
{
    internal class DatabaseConnections
    {
        public NpgsqlConnection Connect()
        {
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server={0};Port={1};" +
                                                  "User Id={2};Password={3};Database={4};",
                                                  "localhost", "5432", "postgres",
                                                   "1234", "e-Projects");
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                return conn;
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                Console.WriteLine(msg.ToString());
                throw;
            }
        }
    }
}