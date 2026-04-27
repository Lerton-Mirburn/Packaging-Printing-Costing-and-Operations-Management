using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace PPCOM.Data
{
    public class DatabaseInitializer
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=master;Integrated Security=True;"; //Kết nối vào master
        SqlConnection connection;
        SqlCommand command;
        DataTable table;
        public DatabaseInitializer()
        {

        }
        public void Initialize()
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                    "IF DB_ID('PPCOM') IS NULL CREATE DATABASE PPCOM", conn);

                    cmd.ExecuteNonQuery();
                }
                string connStrPPCOM = @"Server=(localdb)\MSSQLLocalDB;Database=PPCOM;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connStrPPCOM))
                {
                    conn.Open();

                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database_Init.sql");
                    string sql = File.ReadAllText(path);
                    string[] commands = sql.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string commandText in commands)
                    {
                        if (string.IsNullOrWhiteSpace(commandText)) continue;

                        using (SqlCommand cmd = new SqlCommand(commandText, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
