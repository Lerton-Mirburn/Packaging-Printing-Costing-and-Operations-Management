using PPCOM.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

                SqlCommand cmd = new SqlCommand("sp_GetUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new User
                    {
                        user_id = (int)reader["user_id"],
                        username = reader["username"].ToString(),
                        email = reader["email"] != DBNull.Value ? reader["email"].ToString() : null,
                        full_name = reader["full_name"].ToString(),
                        role_id = (int)reader["role_id"],
                        role_name = reader["role_name"].ToString(),
                        state_text = reader["state_text"].ToString()
                    });
                }
            }

            return list;
        }

        public List<User> SearchUsers(string keyword)
        {
            List<User> list = new List<User>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM View_UserList WHERE full_name LIKE @keyword OR email LIKE @keyword OR username LIKE @keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new User
                    {
                        user_id = (int)reader["user_id"],
                        username = reader["username"].ToString(),
                        email = reader["email"] != DBNull.Value ? reader["email"].ToString() : null,
                        full_name = reader["full_name"].ToString(),
                        role_id = (int)reader["role_id"],
                        role_name = reader["role_name"].ToString(),
                        state_text = reader["state_text"].ToString()
                    });
                }
            }

            return list;
        }

        public List<Role> GetRoles()
        {
            List<Role> list = new List<Role>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_GetRoles", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Role
                    {
                        role_id = (int)reader["role_id"],
                        role_name = reader["role_name"].ToString()
                    });
                }
            }

            return list;
        }

        public User CheckLogin(string username, string password)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_CheckLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            user_id = Convert.ToInt32(reader["user_id"]),
                            username = reader["username"].ToString(),
                            email = reader["email"] != DBNull.Value ? reader["email"].ToString() : null,
                            full_name = reader["full_name"].ToString(),
                            state = Convert.ToByte(reader["state"]),
                            role_id = reader["role_id"] != DBNull.Value ? Convert.ToInt32(reader["role_id"]) : 0
                        };
                    }
                }
            }
            return user;
        }

        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_AddUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = user.username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = user.password;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = (object)user.email ?? DBNull.Value;
                cmd.Parameters.Add("@full_name", SqlDbType.NVarChar, 100).Value = user.full_name;
                cmd.Parameters.Add("@state", SqlDbType.TinyInt).Value = user.state;
                cmd.Parameters.Add("@role_id", SqlDbType.Int).Value = user.role_id;

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_UpdateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id", user.user_id);
                cmd.Parameters.AddWithValue("@full_name", user.full_name);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@role_id", user.role_id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_DeleteUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id", userId);

                cmd.ExecuteNonQuery();
            }
        }

        public void ToggleUserState(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_ToggleUserState", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id", userId);

                cmd.ExecuteNonQuery();
            }
        }
        public bool CheckEmailExists(string email)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void SaveOTP(string email, string otp, DateTime expiry)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_SaveOTP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@otp", otp);
                cmd.Parameters.AddWithValue("@expiry", expiry);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool VerifyOTP(string email, string otp)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_VerifyOTP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@otp", otp);
                conn.Open();
                int result = (int)cmd.ExecuteScalar();
                return result > 0;
            }
        }

        public bool UpdatePassword(string email, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdatePassword", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@new_password", newPassword);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public void ResetPasswordByUserId(int userId, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Users SET password = @password WHERE user_id = @user_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", newPassword);
                cmd.Parameters.AddWithValue("@user_id", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}