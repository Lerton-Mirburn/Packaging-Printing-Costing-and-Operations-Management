using PPCOM.Data;
using PPCOM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Services
{
    public class UserService
    {
        private UserRepository repo = new UserRepository();

        public List<User> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public List<User> SearchEmployees(string keyword)
        {
            return repo.SearchUsers(keyword);
        }

        public User Login(string username, string password)
        {
            return repo.CheckLogin(username, password);
        }

        public void AddUser(string txtFullName, string txtUsername, string txtEmail, string txtPassword, int cbRole)
        {
            User user = new User
            {
                username = txtUsername,
                password = txtPassword,
                email = txtEmail,
                full_name = txtFullName,
                state = 1,
                role_id = cbRole
            };

            repo.AddUser(user);
        }
        public void UpdateUser(int id, string fullName, string email, int roleId)
        {
            User user = new User
            {
                user_id = id,
                email = email,
                full_name = fullName,
                role_id = roleId
            };

            repo.UpdateUser(user);
        }
        public void DeleteUser(int id)
        {
            repo.DeleteUser(id);
        }

        public void ToggleUserState(int id)
        {
            repo.ToggleUserState(id);
        }

        public List<Role> GetRoles()
        {
            return repo.GetRoles();
        }


        public string GenerateAndSendOTP(string email)
        {
            if (!repo.CheckEmailExists(email))
            {
                return "Email không tồn tại trong hệ thống!";
            }

            Random rd = new Random();
            string otp = rd.Next(100000, 999999).ToString();

            repo.SaveOTP(email, otp, DateTime.Now.AddMinutes(5));

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("your_email@gmail.com"); // Thay bằng email thật của bạn
                mail.To.Add(email);
                mail.Subject = "Mã xác nhận quên mật khẩu phần mềm PPCOM";
                mail.Body = $"Mã OTP của bạn là: {otp}. Mã này sẽ hết hạn trong 5 phút.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("your_email@gmail.com", "YOUR_APP_PASSWORD"); // Thay bằng mật khẩu ứng dụng Gmail
                smtp.EnableSsl = true;

                smtp.Send(mail);
                return "OK";
            }
            catch (Exception ex)
            {
                return "Lỗi gửi email: " + ex.Message;
            }
        }

        public bool ValidateOTP(string email, string otp)
        {
            return repo.VerifyOTP(email, otp);
        }

        public bool ResetPassword(string email, string newPassword)
        {
            return repo.UpdatePassword(email, newPassword);
        }

        public void ResetPasswordByUserId(int userId, string newPassword)
        {
            repo.ResetPasswordByUserId(userId, newPassword);
        }
    }
}