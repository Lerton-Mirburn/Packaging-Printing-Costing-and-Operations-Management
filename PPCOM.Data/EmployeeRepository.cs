//IMPORTANT
using PPCOM.Models;
//IMPORTANT

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Data
{
    public class EmployeeRepository
    {
         string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=PPCOM;Trusted_Connection=True;";
        public List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM Employees";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Employee
                    {
                        employee_id = (int)reader["employee_id"],
                        name = reader["name"].ToString(),
                        position = reader["position"].ToString(),
                        salary = (decimal)reader["salary"]
                    });
                }
            }

            return list;
        }
    }
}
