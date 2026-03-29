using System;
using System.Windows.Forms;
using PPCOM.UI.Controls;

namespace LoginSystem
{
    public partial class FormLoginUI : Form
    {
        public FormLoginUI()
        {
            InitializeComponent();
            LoadUserControl(new ucLogin());
        }

        public void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;

            if (pnlAuthContainer.Controls.Count > 0)
            {
                var oldControl = pnlAuthContainer.Controls[0];
                pnlAuthContainer.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

<<<<<<< HEAD
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {

        }

        private void pnlAuthContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnlAuthContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}