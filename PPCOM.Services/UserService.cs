using PPCOM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IMPORTANT
using PPCOM.Models;
//IMPORTANT

namespace PPCOM.Services
{
    public class UserService
    {
        private UserRepository repo = new UserRepository();

        // Hàm cũ của bạn (giữ nguyên để không bị lỗi các phần khác)
        public List<User> GetEmployees()
        {
            return repo.GetEmployees();
        }

        // @ SỬA: THÊM HÀM LOGIN VÀO ĐÂY ĐỂ XỬ LÝ ĐĂNG NHẬP
        public bool Login(string username, string password)
        {
            // Tạm thời mình fix cứng tài khoản là admin/123 để bạn test luồng chuyển Form trước
            // Sau này khi kết nối Database hoàn chỉnh, bạn có thể gọi lệnh từ repo, ví dụ:
            // return repo.CheckLogin(username, password);

            if (username == "admin" && password == "123")
            {
                return true; // Đăng nhập thành công
            }

            return false; // Đăng nhập thất bại
        }
    }
}