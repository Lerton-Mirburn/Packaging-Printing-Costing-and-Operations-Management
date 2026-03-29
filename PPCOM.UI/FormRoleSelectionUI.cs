using System;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class FormRoleSelection : Form
    {
        public FormRoleSelection()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormLoginUI loginForm = new FormLoginUI();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLoginUI loginForm = new FormLoginUI();
            loginForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void BtnClose_Click(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}