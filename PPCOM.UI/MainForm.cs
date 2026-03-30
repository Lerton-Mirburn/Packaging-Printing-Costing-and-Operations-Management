using PPCOM.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPCOM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadPage(new DashboardControl());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadPage(UserControl page)
        {
            panelContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            LoadPage(new EmployeeControl());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            LoadPage(new CalculateControl());
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardControl());
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
