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
        public MainForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            LoadPage(new DashboardControl());
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

            void Place(Control ctrl)
            {
                ctrl.Top = currentTop;
                currentTop = ctrl.Bottom + spacing;
            }

            void PlaceWithPanel(Control button, Panel panel)
            {
                Place(button);

                if (panel.Visible)
                {
                    panel.Top = currentTop;
                    currentTop = panel.Bottom + spacing;
                }
            }

            Place(btnCalculate);
            PlaceWithPanel(btnOrder, pnlPurchase);
            Place(btnProduce);
            PlaceWithPanel(btnStorage, pnlStorage);
            PlaceWithPanel(btnDebtAndPay, pnlDebt);   // 🔥 new
            PlaceWithPanel(btnReport, pnlReport);     // 🔥 new
            Place(btnEstimate);

            panelSidebar.AutoScrollMinSize = new Size(0, currentTop + 10);
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

        bool isCollapsed = true;
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
