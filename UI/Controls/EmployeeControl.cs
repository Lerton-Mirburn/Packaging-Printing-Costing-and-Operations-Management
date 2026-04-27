using PPCOM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;


namespace PPCOM.Controls
{
    public partial class EmployeeControl : UserControl
    {
        UserService service = new UserService();
        public EmployeeControl()
        {
            InitializeComponent();
            LoadEmployee();
        }
        Image lockImg = Properties.Resources.Lock;
        Image unlockImg = Properties.Resources.Unlock;
        private void LoadEmployee()
        {
            dataGridView1.DataSource = service.GetEmployees();
            dataGridView1.Columns["user_id"].Visible = false;
            dataGridView1.Columns["username"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["state"].Visible = false;
            dataGridView1.Columns["role_id"].Visible = false ;

            dataGridView1.Columns["state_text"].HeaderText = "Trạng thái";
            dataGridView1.Columns["full_name"].HeaderText = "Họ tên";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["role_name"].HeaderText = "Vai trò";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string state = row.Cells["state_text"].Value.ToString();

                if (state == "Deactivated")
                    row.Cells["btnStateCol"].Value = unlockImg; 
                else
                    row.Cells["btnStateCol"].Value = lockImg;  
            }
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["btnEditCol"].DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["btnEnableCol"].DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["btnDeleteCol"].DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["btnStateCol"].DisplayIndex = dataGridView1.Columns.Count - 1;

            dataGridView1.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployee();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditCol")
            {
                int userId = (int)row.Cells["user_id"].Value;
                string fullName = row.Cells["full_name"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                int roleId = (int)row.Cells["role_id"].Value;

                FormEdit form = new FormEdit(userId, fullName,email,roleId);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployee();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDeleteCol")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value;
                service.DeleteUser(id);

                DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa người dùng này?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);

                if (result == DialogResult.Yes)
                {
                    service.DeleteUser(id);
                    LoadEmployee();
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEnableCol")
            {
                MessageBox.Show("btnEnableCol clicked!");
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnStateCol")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value;
                string state = dataGridView1.Rows[e.RowIndex].Cells["state_text"].Value.ToString();

                string action = (state == "Deactivated") ? "activate" : "deactivate";

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn {action} người dùng này?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    service.ToggleUserState(id);
                    LoadEmployee();
                }
            }
        }
    }
}
