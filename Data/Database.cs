using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Data
{
    public class Database
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PPCOM;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
