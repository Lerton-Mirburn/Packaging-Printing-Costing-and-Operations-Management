using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPCOM;

namespace LoginSystem
{
    public partial class FormForgotPasswordUI : Form
    {
        public FormForgotPasswordUI()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormLoginUI loginForm = new FormLoginUI();
            loginForm.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            otpUI otpForm = new otpUI();
            otpForm.Show();
            this.Hide();
        }
    }
}
