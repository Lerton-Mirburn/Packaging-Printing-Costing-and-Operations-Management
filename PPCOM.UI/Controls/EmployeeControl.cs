using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PPCOM.Services;


namespace PPCOM.Controls
{
    public partial class EmployeeControl : UserControl
    {
        UserService service = new UserService();
        public EmployeeControl()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadEmployees()
        {
            dataGridView1.DataSource = service.GetEmployees();
        }
    }
}
