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
        private string connStr;
        public DatabaseInitializer(string connectionString)
        {
            connStr = connectionString;
        }
        public void ExecuteSqlFile(string path)
        {
            string sql = File.ReadAllText(path);

            string[] commands = sql.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                foreach (string command in commands)
                {
                    if (string.IsNullOrWhiteSpace(command)) continue;

                    SqlCommand cmd = new SqlCommand(command, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Initialize()
        {
            ExecuteSqlFile("Data/create_tables.sql");
            ExecuteSqlFile("Data/create_functions.sql");
            ExecuteSqlFile("Data/create_procedures.sql");
            ExecuteSqlFile("Data/create_insertion.sql");
        }
    }
}
