using PPCOM;
using PPCOM.Models;
using PPCOM.Services;
using System;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class FormLoginUI : Form
    {
        private string roleType;

        public FormLoginUI(string roleType = "")
        {
            InitializeComponent();
            this.roleType = roleType;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void BtnEmployee_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void pnlAuthContainer_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click_1(object sender, EventArgs e) { }
        private void label7_Click_1(object sender, EventArgs e) { }
        private void label5_Click_1(object sender, EventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void pictureBox3_Click_1(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label8_Click_1(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint_1(object sender, PaintEventArgs e) { }
        private void pnlAuthContainer_Paint_1(object sender, PaintEventArgs e) { }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            UserService service = new UserService();

            // Sửa lỗi ở đây: Hứng kết quả trả về là một object User
            User loggedInUser = service.Login(username, password);

            // Kiểm tra xem User có tồn tại (không bị null) hay không
            if (loggedInUser != null)
            {
                bool roleValid = true;

                if (!string.IsNullOrEmpty(this.roleType))
                {
                    // Admin: role_id = 1
                    if (this.roleType == "Admin" && loggedInUser.role_id != 1) roleValid = false;
                    // Employee: role_id != 1
                    if (this.roleType == "Employee" && loggedInUser.role_id == 1) roleValid = false;
                }

                if (roleValid)
                {
                    MainForm main = new MainForm();
                    main.Show();

                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                    }
                }
                else
                {
                    this.label10.Text = "Tài khoản của bạn không có quyền đăng nhập vào mục này!";
                    this.guna2Panel2.Visible = true;
                }
            }
            else
            {
                this.label10.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                this.guna2Panel2.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.guna2Panel2.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormRoleSelection roleForm = new FormRoleSelection();
            roleForm.Show();
            this.Hide();
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPasswordUI forgotForm = new FormForgotPasswordUI();
            forgotForm.Show();
            this.Hide();
        }

        private void FormLoginUI_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }
    }
}