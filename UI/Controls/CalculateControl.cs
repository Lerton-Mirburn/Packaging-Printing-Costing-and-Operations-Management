using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PPCOM.Services;


namespace PPCOM.Controls
{
    public partial class CalculateControl : UserControl
    {
        bool bigPrinter = false;
        CalculatorService calc = new CalculatorService();
        QuotationService qs = new QuotationService();

        public CalculateControl()
        {
            InitializeComponent();
        }

        private void CalculateControl_Load(object sender, EventArgs e)
        {
            cbPaperType.DataSource = qs.GetPaperTypes();
            cbPaperType.DisplayMember = "paperName";
            cbPaperType.ValueMember = "paperTypeId";
        }
        int productAmount;
        int colorAmount;
        int unitsPerSheet;
        int wasteSheet;
        double length;
        double width;
        double gsm;
        double PaperPricePerTon;
        double uvFrameCost;
        double dieCuttingFrameCost;
        double profit;
        private void Calculate()
        {
            try
            {
                // Lấy dữ liệu từ TextBox
                productAmount = (int)numProductAmount.Value;
                colorAmount = (int)numColorAmount.Value;
                unitsPerSheet = (int)numUnitsPerSheet.Value;
                wasteSheet = (int)numWasteSheet.Value;

                length = (int)numLength2.Value;
                width = (int)numWidth2.Value;

                paperType selected = (paperType)cbPaperType.SelectedItem;

                gsm = selected.gsm;
                PaperPricePerTon = selected.pricePerTon;

                uvFrameCost = (int)numUvFrameCost.Value;

                dieCuttingFrameCost = (int)numDieCuttingFrameCost.Value;

                profit = (double)numProfit.Value / 100;

                // Gọi service
                double ramCost = calc.RamCost(length, width,gsm, PaperPricePerTon);
                double requiredRam =
                   calc.RequiredSheets(productAmount, unitsPerSheet, wasteSheet) / 500;

                double sheetCost = calc.SheetCost(requiredRam, ramCost);

                double printingCost = calc.PrintingCost(colorAmount,productAmount);

                double plateCost = calc.PlateCost(bigPrinter,colorAmount);

                double uvCost = calc.UvCost(length, width);

                double matteLaminationCost = calc.MatteLaminationCost(length,width,unitsPerSheet,productAmount);

                double dieCuttingCost = calc.DieCuttingCost(unitsPerSheet, productAmount);

                double gluingCost = calc.GluingCost(productAmount);

                double boxCost = calc.BoxCost(productAmount);

                double deliveryCost = 500000;

                double proffPrintingCost = 100000;

                double total = calc.Total(sheetCost,plateCost,printingCost,uvCost,uvFrameCost
                                        ,matteLaminationCost,dieCuttingCost,dieCuttingFrameCost
                                        ,gluingCost,boxCost,deliveryCost,proffPrintingCost);

                // Gán vào Label
                lblRamCost.Text = "=> Giá / Ram: " + ramCost +"đ";
                lblRequired.Text = "=> Cần mua: " + requiredRam;

                lblSheetCost.Text = "THÀNH TIỀN GIẤY: " + sheetCost + "đ";

                lblPrintingCost.Text = printingCost + "đ";

                lblUvCost.Text = printingCost + "đ";
                lblMatteLaminationCost.Text = matteLaminationCost + "đ";
                lblDieCuttingCost.Text = dieCuttingCost + "đ";
                lblGluingCost.Text = gluingCost + "đ";
                lblBoxCost.Text = boxCost + "đ";

                double productPrice = total / productAmount;

                lblProductPrice.Text = "GIÁ MỘT SẢN  PHẨM: " + productPrice + "đ";
                lblCustomerProductPrice.Text = "GIÁ CẦN BÁO CHO KHÁCH: " + (productPrice * (1+profit)) + "đ";

            }
            catch
            {
                // tránh crash khi user đang nhập dở
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bigPrinter = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bigPrinter = true;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numWidth2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLength2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = qs.AddQuotation(
                dtpCreateDate.Value,
                txtCustomerName.Text,
                txtLocation.Text,
                txtProductName.Text,
                txtExpiry.Text,
                txtDeliveryTime.Text,
                (int)numProfit.Value
            );
        }

        private void numProductAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}


