using PPCOM.Controls;
using PPCOM.UI.Controls;
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
        private Stack<UserControl> navigationHistory = new Stack<UserControl>();
        private PPCOM.Models.User _currentUser;

        public MainForm(PPCOM.Models.User loggedInUser = null)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            _currentUser = loggedInUser;
            isCollapsed = panelSidebar.Width <= 60;
            LoadPage(new DashboardControl());
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            
            if (_currentUser != null)
            {
                lbUserName.Text = FixString(_currentUser.full_name);
                if (_currentUser.role_id == 1) // Giả sử 1 là Admin
                {
                    pictureBox3.Image = Properties.Resources.admin_icon;
                }
                else
                {
                    pictureBox3.Image = Properties.Resources.uis_user_md;
                }
            }
        }

        private string FixString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            try
            {
                byte[] bytes = Encoding.GetEncoding("Windows-1252").GetBytes(input);
                return Encoding.UTF8.GetString(bytes);
            }
            catch { return input; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureLogo_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardControl());
        }
        private void UpdateSidebarLayout()
        {
            int spacing = 15;
            int currentTop = btnEmployee.Bottom + spacing;

            btnCalculate.Top = currentTop;
            currentTop = btnCalculate.Bottom + spacing;

            btnOrder.Top = currentTop;
            currentTop = btnOrder.Bottom + spacing;

            if (pnlPurchase.Visible)
            {
                pnlPurchase.Top = currentTop;
                currentTop = pnlPurchase.Bottom + spacing;
            }

            btnProduce.Top = currentTop;
            currentTop = btnProduce.Bottom + spacing;

            btnStorage.Top = currentTop;
            currentTop = btnStorage.Bottom + spacing;

            if (pnlStorage.Visible)
            {
                pnlStorage.Top = currentTop;
                currentTop = pnlStorage.Bottom + spacing;
            }

            btnDebtAndPay.Top = currentTop;
            currentTop = btnDebtAndPay.Bottom + spacing;

            if (pnlDebt.Visible)
            {
                pnlDebt.Top = currentTop;
                currentTop = pnlDebt.Bottom + spacing;
            }

            btnReport.Top = currentTop;
            currentTop = btnReport.Bottom + spacing;

            if (pnlReport.Visible)
            {
                pnlReport.Top = currentTop;
                currentTop = pnlReport.Bottom + spacing;
            }

            btnEstimate.Top = currentTop;
            currentTop = btnEstimate.Bottom + spacing;

            panelSidebar.AutoScrollMinSize = new Size(0, currentTop + 10);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadPage(UserControl page)
        {
            if (panelContent.Controls.Count > 0)
            {
                UserControl current = panelContent.Controls[0] as UserControl;
                if (current != null && current.GetType() != page.GetType())
                {
                    navigationHistory.Push(current);
                }
            }
            panelContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (navigationHistory.Count > 0)
            {
                UserControl prev = navigationHistory.Pop();
                panelContent.Controls.Clear();
                prev.Dock = DockStyle.Fill;
                panelContent.Controls.Add(prev);
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            LoadPage(new EmployeeControl());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            LoadPage(new CalculateControl());
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlPurchase.Visible = !pnlPurchase.Visible;
            UpdateSidebarLayout();
}

        private void btnProduce_Click(object sender, EventArgs e)
        {
            LoadPage(new ProductionControl());
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            pnlStorage.Visible = !pnlStorage.Visible;
            UpdateSidebarLayout();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            pnlDebt.Visible = !pnlDebt.Visible;
            UpdateSidebarLayout();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlReport.Visible = !pnlReport.Visible;
            UpdateSidebarLayout();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            LoadPage(new ImportStorageControl());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            LoadPage(new ExportControl());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadPage(new StorageControl());
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Tìm kiếm")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Tìm kiếm";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void btnReportStorage_Click(object sender, EventArgs e)
        {
            LoadPage(new ReportStorageControl());
        }

        private void btnCreatePurchaseOrder_Click(object sender, EventArgs e)
        {
            LoadPage(new CreatePurchaseOrderControl());
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            LoadPage(new PurchaseControl());
        }

        private void btnDebtManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPurchaseDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnDebtDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchaseSummary_Click(object sender, EventArgs e)
        {

        }

        private void btnDebtSummary_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        bool isCollapsed;
        private void PictureMenu_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelSidebar.Width = 323; // expand
                isCollapsed = false;
            }
            else
            {
                panelSidebar.Width = 60; // shrink
                isCollapsed = true;
            }
        }
    }
}
