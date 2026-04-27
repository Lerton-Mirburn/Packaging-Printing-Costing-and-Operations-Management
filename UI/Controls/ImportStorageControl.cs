using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPCOM.Data;
namespace PPCOM.Controls
{
    public partial class ImportStorageControl : UserControl
    {
        public ImportStorageControl()
        {
            InitializeComponent();
            this.Load += ImportStorageControl_Load;
            dgv.RowPostPaint += Dgv_RowPostPaint;
        }
        private void ImportStorageControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            StorageData storageData = new StorageData();
            DataTable dt = storageData.GetImportStockList();
            dgv.DataSource = dt;
        }
        private void Dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
