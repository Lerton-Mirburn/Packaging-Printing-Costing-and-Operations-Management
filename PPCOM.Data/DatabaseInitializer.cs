using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace PPCOM.Data
{
    public class DatabaseInitializer
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PPCOM;Integrated Security=True;";
        SqlConnection connection;
        SqlCommand command;
        DataTable table;
        public DatabaseInitializer()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            table = new DataTable();
        }
        public void Initialize()
        {
            try
            {
                string masterConn =
                @"Server=(localdb)\MSSQLLocalDB;Database=master;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(masterConn))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                    "IF DB_ID('PPCOM') IS NULL CREATE DATABASE PPCOM", conn);

                    cmd.ExecuteNonQuery();
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = File.ReadAllText("Database_Init.sql");

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
