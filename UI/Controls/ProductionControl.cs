using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PPCOM.Data;

namespace PPCOM.UI.Controls
{
    public partial class ProductionControl : UserControl
    {
        private readonly Database db = new Database();
        private DataTable productionTable;

        public ProductionControl()
        {
            InitializeComponent();

            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;

            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY q.quotation_id DESC) AS STT,
                        q.quotation_id,
                        q.addresses AS [Địa chỉ],
                        q.customer_name AS [Tên khách hàng],
                        q.product_name AS [Tên sản phẩm],
                        q.quotation_date AS [Ngày báo giá]
                    FROM Quotations q
                    ORDER BY q.quotation_id DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                productionTable = new DataTable();
                da.Fill(productionTable);
            }

            dgvProduction.Columns.Clear();
            dgvProduction.DataSource = productionTable;
            dgvProduction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduction.MultiSelect = false;
            dgvProduction.Columns["quotation_id"].Visible = false;

            DataGridViewButtonColumn detailCol = new DataGridViewButtonColumn();
            detailCol.Name = "ChiTiet";
            detailCol.HeaderText = "Chi tiết";
            detailCol.Text = "✎";
            detailCol.UseColumnTextForButtonValue = true;
            dgvProduction.Columns.Add(detailCol);

            DataGridViewButtonColumn exportCol = new DataGridViewButtonColumn();
            exportCol.Name = "XuatLenh";
            exportCol.HeaderText = "Xuất lệnh";
            exportCol.Text = "Lưu & xuất pdf";
            exportCol.UseColumnTextForButtonValue = true;
            dgvProduction.Columns.Add(exportCol);

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (productionTable == null) return;

            DateTime from = dtpFromDate.Value.Date;
            DateTime to = dtpToDate.Value.Date;

            productionTable.DefaultView.RowFilter =
                string.Format("[Ngày báo giá] >= #{0:MM/dd/yyyy}# AND [Ngày báo giá] <= #{1:MM/dd/yyyy}#", from, to);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvProduction.CurrentRow == null) return;

            int quotationId = Convert.ToInt32(
                dgvProduction.CurrentRow.Cells["quotation_id"].Value
            );

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa báo giá này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sql = @"
                DELETE FROM Production_Orders 
                WHERE quotation_id = @id;

                DELETE FROM Quotation_Details 
                WHERE quotation_id = @id;

                DELETE FROM Quotations 
                WHERE quotation_id = @id;
            ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@id", quotationId);
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();

                    MessageBox.Show("Đã xóa thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    tran.Rollback();

                    MessageBox.Show(
                        "Không xóa được dữ liệu.\n\nLỗi: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void dgvProduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvProduction.Columns[e.ColumnIndex].Name;
            int quotationId = Convert.ToInt32(dgvProduction.Rows[e.RowIndex].Cells["quotation_id"].Value);

            if (columnName == "ChiTiet")
            {
                MessageBox.Show("Mở chi tiết báo giá ID = " + quotationId);
            }
            else if (columnName == "XuatLenh")
            {
                CreateProductionOrder(quotationId);
            }
        }

        private void CreateProductionOrder(int quotationId)
        {
            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_create_production_order", conn))
            {
                conn.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@quotation_id", quotationId);
                cmd.Parameters.AddWithValue("@start_date", DateTime.Today);
                cmd.Parameters.AddWithValue("@end_date", DateTime.Today.AddDays(7));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã tạo lệnh sản xuất thành công!");
        }
    }
}