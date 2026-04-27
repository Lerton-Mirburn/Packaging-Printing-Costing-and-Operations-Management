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
    public partial class DetailReportControl : UserControl
    {
        public DetailReportControl()
        {
            InitializeComponent();
        }


        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DetailReportControl_Load(object sender, EventArgs e)
        {
            dgvItems.Columns.Clear();

            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Checkbox column
            DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
            colCheck.Name = "colCheck";
            colCheck.HeaderText = "";
            dgvItems.Columns.Add(colCheck);

            // Text columns
            dgvItems.Columns.Add("colCode", "Mã hàng");
            dgvItems.Columns.Add("colName", "Tên hàng");

            // Width ratio
            dgvItems.Columns["colCheck"].FillWeight = 10;
            dgvItems.Columns["colCode"].FillWeight = 30;
            dgvItems.Columns["colName"].FillWeight = 60;

            // UI đẹp hơn
            dgvItems.RowHeadersVisible = false;
            dgvItems.Columns["colCheck"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
