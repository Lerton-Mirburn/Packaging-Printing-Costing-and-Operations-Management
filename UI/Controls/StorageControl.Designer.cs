using System.Drawing;

namespace PPCOM.Controls
{
    partial class StorageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblVTHH = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbVTHH = new System.Windows.Forms.ComboBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tổng hợp tồn kho";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSubtitle.Location = new System.Drawing.Point(20, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(100, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Chọn tham số";

            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(20, 84);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(71, 19);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Chi nhánh";

            // 
            // cbBranch
            // 
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(20, 106);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(760, 28);
            this.cbBranch.TabIndex = 3;

            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(20, 145);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(75, 19);
            this.lblReport.TabIndex = 4;
            this.lblReport.Text = "Kỳ báo cáo";

            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince.Location = new System.Drawing.Point(360, 145);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(59, 19);
            this.lblSince.TabIndex = 5;
            this.lblSince.Text = "Từ ngày";

            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(570, 145);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(67, 19);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "Đến ngày";

            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(20, 206);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(78, 19);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "Đơn vị tính";

            // 
            // lblVTHH
            // 
            this.lblVTHH.AutoSize = true;
            this.lblVTHH.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTHH.Location = new System.Drawing.Point(360, 206);
            this.lblVTHH.Name = "lblVTHH";
            this.lblVTHH.Size = new System.Drawing.Size(87, 19);
            this.lblVTHH.TabIndex = 8;
            this.lblVTHH.Text = "Nhóm VTHH";

            // 
            // cbReport
            // 
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(20, 167);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(300, 28);
            this.cbReport.TabIndex = 9;

            // 
            // dtpSince
            // 
            this.dtpSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSince.Location = new System.Drawing.Point(360, 167);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(150, 27);
            this.dtpSince.TabIndex = 10;

            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(570, 167);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 27);
            this.dtpTo.TabIndex = 11;

            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(20, 228);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(300, 28);
            this.cbUnit.TabIndex = 12;

            // 
            // cbVTHH
            // 
            this.cbVTHH.FormattingEnabled = true;
            this.cbVTHH.Location = new System.Drawing.Point(360, 228);
            this.cbVTHH.Name = "cbVTHH";
            this.cbVTHH.Size = new System.Drawing.Size(300, 28);
            this.cbVTHH.TabIndex = 13;

            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(20, 272);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(120, 24);
            this.chkAll.TabIndex = 14;
            this.chkAll.Text = "Chọn tất cả kho";
            this.chkAll.UseVisualStyleBackColor = true;

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(360, 270);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 27);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "Tìm kiếm vật tư, hàng hóa...";
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);

            // 
            // dgvStore
            // 
            this.dgvStore.AllowUserToAddRows = false;
            this.dgvStore.BackgroundColor = System.Drawing.Color.White;
            this.dgvStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(226, 239, 218);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStore.ColumnHeadersHeight = 32;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStore.Location = new System.Drawing.Point(20, 315);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.RowHeadersWidth = 51;
            this.dgvStore.RowTemplate.Height = 28;
            this.dgvStore.Size = new System.Drawing.Size(1120, 240);
            this.dgvStore.TabIndex = 16;

            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(20, 565);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(117, 20);
            this.lblSum.TabIndex = 17;
            this.lblSum.Text = "Tổng số dòng: 0";

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(20, 595);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(135, 595);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 32);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Xoá điều kiện";
            this.btnClear.UseVisualStyleBackColor = false;

            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.ForestGreen;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Control;
            this.btnView.Location = new System.Drawing.Point(1010, 595);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(130, 32);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "Xem báo cáo";
            this.btnView.UseVisualStyleBackColor = false;

            // 
            // StorageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(182, 226, 185);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.cbVTHH);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpSince);
            this.Controls.Add(this.cbReport);
            this.Controls.Add(this.lblVTHH);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblSince);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StorageControl";
            this.Size = new System.Drawing.Size(1160, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblSince;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblVTHH;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.DateTimePicker dtpSince;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbVTHH;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnView;
    }
}