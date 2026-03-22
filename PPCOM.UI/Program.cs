using PPCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPCOM.Data;
namespace LoginSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Khởi tạo cơ sở dữ liệu
            DatabaseInitializer db = new DatabaseInitializer();
            db.Initialize();
            //Tự động khởi tạo localDB cho ứng dụng nếu chưa tồn tại để tránh lỗi khi chạy ứng dụng lần đầu tiên
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLoginUI());
        }
    }
}
