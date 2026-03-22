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
<<<<<<< HEAD
            Application.Run(new FormLoginUI());
=======

            Application.Run(new FormRoleSelection());
>>>>>>> 07a4efac2de0b5050a17b6109040ff2500719157
        }
    }
}