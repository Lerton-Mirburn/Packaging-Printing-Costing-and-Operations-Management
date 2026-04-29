namespace PPCOM.UI.Controls
{
    partial class ProductionControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.dgvProduction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH SẢN XUẤT THEO BẢNG TÍNH GIÁ";

            // btnDeleteRow
            this.btnDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)
                ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(230, 80, 80);
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteRow.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRow.Location = new System.Drawing.Point(1010, 10);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(135, 32);
            this.btnDeleteRow.TabIndex = 1;
            this.btnDeleteRow.Text = "Xóa dòng";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);

            // lblFromDate
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFromDate.Location = new System.Drawing.Point(18, 60);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(65, 19);
            this.lblFromDate.TabIndex = 2;
            this.lblFromDate.Text = "Từ ngày";

            // dtpFromDate
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(18, 82);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(135, 27);
            this.dtpFromDate.TabIndex = 3;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);

            // lblToDate
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblToDate.Location = new System.Drawing.Point(180, 60);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(74, 19);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "Đến ngày";

            // dtpToDate
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(180, 82);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(135, 27);
            this.dtpToDate.TabIndex = 5;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);

            // dgvProduction
            this.dgvProduction.AllowUserToAddRows = false;
            this.dgvProduction.AllowUserToResizeRows = false;
            this.dgvProduction.Anchor = ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduction.BackgroundColor = System.Drawing.Color.FromArgb(182, 226, 185);
            this.dgvProduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduction.ColumnHeadersHeight = 38;
            this.dgvProduction.EnableHeadersVisualStyles = false;
            this.dgvProduction.GridColor = System.Drawing.Color.FromArgb(90, 140, 95);
            this.dgvProduction.Location = new System.Drawing.Point(15, 130);
            this.dgvProduction.MultiSelect = false;
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowHeadersVisible = false;
            this.dgvProduction.RowHeadersWidth = 51;
            this.dgvProduction.RowTemplate.Height = 34;
            this.dgvProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduction.Size = new System.Drawing.Size(1130, 470);
            this.dgvProduction.TabIndex = 6;
            this.dgvProduction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellContentClick);

            this.dgvProduction.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(182, 226, 185);
            this.dgvProduction.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProduction.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProduction.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(182, 226, 185);
            this.dgvProduction.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProduction.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(145, 205, 150);
            this.dgvProduction.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // ProductionControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(182, 226, 185);
            this.Controls.Add(this.dgvProduction);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ProductionControl";
            this.Size = new System.Drawing.Size(1160, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.DataGridView dgvProduction;
    }
}