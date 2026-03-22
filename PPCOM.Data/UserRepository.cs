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
    public class UserRepository
    {
        string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=PPCOM;Integrated Security=True;";
        public List<User> GetEmployees()
        {
            List<User> list = new List<User>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT user_id, username, password, email, role_id FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new User
                    {
                        user_id = (int)reader["user_id"],
                        username = reader["username"].ToString(),
                        password = reader["password"].ToString(),
                        email = reader["email"].ToString(),
                        role_id = (int)reader["role_id"]

                    });
                }
            }

            return list;
        }

        public bool CheckLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE username=@u AND password=@p";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
