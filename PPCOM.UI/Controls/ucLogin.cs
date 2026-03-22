using System;
using System.Windows.Forms;
using PPCOM;
using PPCOM.Services;

namespace PPCOM.UI.Controls
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            UserService service = new UserService();

            if (service.Login(username, password))
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
                MessageBox.Show("Wrong username or password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e) { }
    }
}