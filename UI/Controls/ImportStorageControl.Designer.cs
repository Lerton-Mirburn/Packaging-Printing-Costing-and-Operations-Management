using System.Drawing;
using System.Windows.Forms;

namespace PPCOM.Controls
{
    partial class ImportStorageControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleDetail = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblIn = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ KHO";
            // 
            // lblTitleDetail
            // 
            this.lblTitleDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleDetail.ForeColor = System.Drawing.Color.Blue;
            this.lblTitleDetail.Location = new System.Drawing.Point(20, 45);
            this.lblTitleDetail.Name = "lblTitleDetail";
            this.lblTitleDetail.Size = new System.Drawing.Size(200, 23);
            this.lblTitleDetail.TabIndex = 1;
            this.lblTitleDetail.Text = "BẢNG CHI TIẾT NHẬP KHO";
            // 
            // lblSince
            // 
            this.lblSince.Location = new System.Drawing.Point(20, 75);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(100, 23);
            this.lblSince.TabIndex = 2;
            this.lblSince.Text = "Từ ngày";
            // 
            // dtpSince
            // 
            this.dtpSince.Location = new System.Drawing.Point(20, 95);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(160, 22);
            this.dtpSince.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(200, 75);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(100, 23);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "Đến ngày";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(200, 95);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(160, 22);
            this.dtpTo.TabIndex = 5;
            // 
            // lblIn
            // 
            this.lblIn.Location = new System.Drawing.Point(380, 75);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(100, 23);
            this.lblIn.TabIndex = 6;
            this.lblIn.Text = "Mua tại";
            // 
            // cbSupplier
            // 
            this.cbSupplier.Location = new System.Drawing.Point(380, 95);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(240, 24);
            this.cbSupplier.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 29;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colCode,
            this.colName,
            this.colQty,
            this.colAction,
            this.colDetail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(20, 140);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1120, 210);
            this.dgv.TabIndex = 8;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "transaction_id";
            this.colCode.HeaderText = "Mã NCC";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "material_name";
            this.colName.HeaderText = "Tên NCC";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "quantity";
            this.colQty.HeaderText = "Số lượng";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Hành động";
            this.colAction.MinimumWidth = 6;
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Text = "Nhập";
            this.colAction.UseColumnTextForButtonValue = true;
            // 
            // colDetail
            // 
            this.colDetail.HeaderText = "Chi tiết";
            this.colDetail.MinimumWidth = 6;
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            this.colDetail.Text = "✏️";
            this.colDetail.UseColumnTextForButtonValue = true;
            // 
            // ImportStorageControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(226)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTitleDetail);
            this.Controls.Add(this.lblSince);
            this.Controls.Add(this.dtpSince);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.dgv);
            this.Name = "ImportStorageControl";
            this.Size = new System.Drawing.Size(1160, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        private Label lblTitle;
        private Label lblTitleDetail;
        private Label lblSince;
        private DateTimePicker dtpSince;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Label lblIn;
        private ComboBox cbSupplier;
        private DataGridView dgv;

        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewButtonColumn colAction;
        private DataGridViewButtonColumn colDetail;
    }
}