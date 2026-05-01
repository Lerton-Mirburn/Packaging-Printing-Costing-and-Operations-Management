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
            
            // Ẩn các cột không cần thiết
            string[] hideCols = { "user_id", "username", "password", "state", "role_id" };
            foreach (var col in hideCols)
            {
                if (dataGridView1.Columns.Contains(col)) dataGridView1.Columns[col].Visible = false;
            }

            // Đặt tiêu đề tiếng Việt
            if (dataGridView1.Columns.Contains("full_name")) dataGridView1.Columns["full_name"].HeaderText = "Họ tên";
            if (dataGridView1.Columns.Contains("email")) dataGridView1.Columns["email"].HeaderText = "Email";
            if (dataGridView1.Columns.Contains("role_name")) dataGridView1.Columns["role_name"].HeaderText = "Vai trò";
            if (dataGridView1.Columns.Contains("state_text")) dataGridView1.Columns["state_text"].HeaderText = "Trạng thái";

            // Sắp xếp thứ tự hiển thị rõ ràng
            int index = 0;
            if (dataGridView1.Columns.Contains("full_name")) dataGridView1.Columns["full_name"].DisplayIndex = index++;
            if (dataGridView1.Columns.Contains("email")) dataGridView1.Columns["email"].DisplayIndex = index++;
            if (dataGridView1.Columns.Contains("role_name")) dataGridView1.Columns["role_name"].DisplayIndex = index++;
            if (dataGridView1.Columns.Contains("state_text")) dataGridView1.Columns["state_text"].DisplayIndex = index++;
            
            if (dataGridView1.Columns.Contains("btnEditCol")) dataGridView1.Columns["btnEditCol"].DisplayIndex = index++;
            if (dataGridView1.Columns.Contains("btnEnableCol")) dataGridView1.Columns["btnEnableCol"].DisplayIndex = index++;
            if (dataGridView1.Columns.Contains("btnDeleteCol")) dataGridView1.Columns["btnDeleteCol"].DisplayIndex = index++;
            if (dataGridView1.Columns.Contains("btnStateCol")) dataGridView1.Columns["btnStateCol"].DisplayIndex = index++;

            UpdateGridIcons();
            FixGridEncoding(); // Tạm thời sửa lỗi hiển thị phông chữ
        }

        private void FixGridEncoding()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["full_name"].Value != null)
                    row.Cells["full_name"].Value = FixString(row.Cells["full_name"].Value.ToString());
                
                if (row.Cells["role_name"].Value != null)
                    row.Cells["role_name"].Value = FixString(row.Cells["role_name"].Value.ToString());
            }
        }

        private string FixString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            try {
                // Thử chuyển đổi từ Windows-1252 (thường là nguồn của Mojibake) sang UTF-8
                byte[] bytes = Encoding.GetEncoding("Windows-1252").GetBytes(input);
                return Encoding.UTF8.GetString(bytes);
            } catch { return input; }
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            
            // Thiết lập sự kiện cho ô tìm kiếm
            
            // Thiết lập sự kiện cho ô tìm kiếm
            textBox1.TextChanged += (s, ev) => {
                string keyword = textBox1.Text.Trim();
                if (keyword == "Tìm kiếm tên nhân viên" || string.IsNullOrEmpty(keyword))
                {
                    LoadEmployee();
                }
                else
                {
                    dataGridView1.DataSource = service.SearchEmployees(keyword);
                    UpdateGridIcons();
                }
            };
            
            textBox1.Enter += (s, ev) => {
                if (textBox1.Text == "Tìm kiếm tên nhân viên")
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = Color.Black;
                }
            };
            
            textBox1.Leave += (s, ev) => {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "Tìm kiếm tên nhân viên";
                    textBox1.ForeColor = Color.Gray;
                }
            };
        }

        private void UpdateGridIcons()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["state_text"].Value != null)
                {
                    string state = row.Cells["state_text"].Value.ToString();
                    if (state == "Deactivated")
                        row.Cells["btnStateCol"].Value = unlockImg;
                    else
                        row.Cells["btnStateCol"].Value = lockImg;
                }
            }
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
            LoadEmployee();
            textBox1.Text = "Tìm kiếm tên nhân viên";
            textBox1.ForeColor = Color.Gray;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa người dùng này?",
                    "Xác nhận xóa",
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
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value;
                string fullName = dataGridView1.Rows[e.RowIndex].Cells["full_name"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có muốn đặt lại mật khẩu cho nhân viên '{fullName}' về mặc định '123456'?",
                    "Đặt lại mật khẩu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    service.ResetPasswordByUserId(id, "123456");
                    MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnStateCol")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value;
                string state = dataGridView1.Rows[e.RowIndex].Cells["state_text"].Value.ToString();

                string action = (state == "Deactivated") ? "kích hoạt" : "vô hiệu hóa";

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn {action} người dùng này?",
                    "Xác nhận",
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
