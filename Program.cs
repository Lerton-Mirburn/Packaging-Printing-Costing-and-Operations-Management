using PPCOM;
using PPCOM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Packaging_Printing_Costing_and_Operations_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            string masterConn = "Server=(localdb)\\MSSQLLocalDB;Database=master;Integrated Security=true;";
            int exists;

            using (SqlConnection conn = new SqlConnection(masterConn))
            {
                conn.Open();

                string sql = "IF DB_ID('PPCOM') IS NULL CREATE DATABASE PPCOM;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=PPCOM;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "IF OBJECT_ID('Users', 'U') IS NULL SELECT 0 ELSE SELECT 1",
                    conn
                );

                exists = (int)cmd.ExecuteScalar();
            }
            DatabaseInitializer dbInit = new DatabaseInitializer(connStr);

            if (exists == 0)
            {
                dbInit.Initialize();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
