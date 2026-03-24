using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPCOM.Data;
using LoginSystem;

namespace PPCOM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseInitializer db = new DatabaseInitializer();
            db.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormRoleSelection());
        }
    }
}
