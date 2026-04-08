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
            this.lblUnit = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lblVTHH = new System.Windows.Forms.Label();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tổng hợp tồn kho";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(100, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Chọn tham số";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(20, 85);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(71, 17);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Chi nhánh";
            // 
            // cbBranch
            // 
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(20, 105);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(680, 24);
            this.cbBranch.TabIndex = 3;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(20, 135);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(75, 17);
            this.lblReport.TabIndex = 4;
            this.lblReport.Text = "Kỳ báo cáo";
            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSince.Location = new System.Drawing.Point(350, 135);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(59, 17);
            this.lblSince.TabIndex = 5;
            this.lblSince.Text = "Từ ngày";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(20, 185);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(78, 17);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "Đơn vị tính";
            // 
            // cbReport
            // 
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(20, 155);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(300, 24);
            this.cbReport.TabIndex = 7;
            // 
            // dtpSince
            // 
            this.dtpSince.Location = new System.Drawing.Point(350, 155);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(150, 22);
            this.dtpSince.TabIndex = 8;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(550, 135);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(59, 17);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "Từ ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(20, 205);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(300, 24);
            this.cbUnit.TabIndex = 11;
            // 
            // lblVTHH
            // 
            this.lblVTHH.AutoSize = true;
            this.lblVTHH.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTHH.Location = new System.Drawing.Point(350, 185);
            this.lblVTHH.Name = "lblVTHH";
            this.lblVTHH.Size = new System.Drawing.Size(87, 17);
            this.lblVTHH.TabIndex = 12;
            this.lblVTHH.Text = "Nhóm VTHH";
            // 
            // cbVTHH
            // 
            this.cbVTHH.FormattingEnabled = true;
            this.cbVTHH.Location = new System.Drawing.Point(350, 205);
            this.cbVTHH.Name = "cbVTHH";
            this.cbVTHH.Size = new System.Drawing.Size(300, 24);
            this.cbVTHH.TabIndex = 13;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(20, 240);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(120, 20);
            this.chkAll.TabIndex = 14;
            this.chkAll.Text = "Chọn tất cả kho";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(350, 238);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 22);
            this.txtSearch.TabIndex = 15;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Location = new System.Drawing.Point(20, 280);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.RowHeadersWidth = 51;
            this.dgvStore.RowTemplate.Height = 24;
            this.dgvStore.Size = new System.Drawing.Size(680, 200);
            this.dgvStore.TabIndex = 16;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(20, 490);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 16);
            this.lblSum.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(20, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(140, 530);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Xoá điều kiện";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.ForestGreen;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Control;
            this.btnView.Location = new System.Drawing.Point(570, 530);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(130, 35);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "Xem báo cáo";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // StorageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.cbVTHH);
            this.Controls.Add(this.lblVTHH);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpSince);
            this.Controls.Add(this.cbReport);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblSince);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "StorageControl";
            this.Size = new System.Drawing.Size(1019, 581);
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
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.DateTimePicker dtpSince;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label lblVTHH;
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
