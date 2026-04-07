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
        private void LoadEmployees()
        {
            dataGridView1.DataSource = service.GetEmployees();
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["btnDeactivateCol"].DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["btnDeleteCol"].DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["btnEditCol"].DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["btnEnableCol"].DisplayIndex = dataGridView1.Columns.Count - 1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
