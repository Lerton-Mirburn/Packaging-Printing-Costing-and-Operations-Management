using System.Drawing;

namespace PPCOM.Controls
{
    partial class ExportControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboExportType = new System.Windows.Forms.ComboBox();
            this.cboProductionOrder = new System.Windows.Forms.ComboBox();
            this.btnGuide = new System.Windows.Forms.Button();
            this.lblReceiverCode = new System.Windows.Forms.Label();
            this.cboReceiverCode = new System.Windows.Forms.ComboBox();
            this.btnAddReceiver = new System.Windows.Forms.Button();
            this.lblReceiverName = new System.Windows.Forms.Label();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.txtAttachmentCount = new System.Windows.Forms.TextBox();
            this.lblOriginalDocument = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblAccountingDate = new System.Windows.Forms.Label();
            this.dtpAccountingDate = new System.Windows.Forms.DateTimePicker();
            this.lblDocumentDate = new System.Windows.Forms.Label();
            this.dtpDocumentDate = new System.Windows.Forms.DateTimePicker();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.lblItemDetails = new System.Windows.Forms.Label();
            this.dgvExportItems = new System.Windows.Forms.DataGridView();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU XUẤT KHO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboExportType
            // 
            this.cboExportType.FormattingEnabled = true;
            this.cboExportType.Location = new System.Drawing.Point(330, 10);
            this.cboExportType.Name = "cboExportType";
            this.cboExportType.Size = new System.Drawing.Size(150, 28);
            this.cboExportType.TabIndex = 1;
            this.cboExportType.Text = "2. Sản xuất";
            // 
            // cboProductionOrder
            // 
            this.cboProductionOrder.FormattingEnabled = true;
            this.cboProductionOrder.Location = new System.Drawing.Point(495, 10);
            this.cboProductionOrder.Name = "cboProductionOrder";
            this.cboProductionOrder.Size = new System.Drawing.Size(190, 28);
            this.cboProductionOrder.TabIndex = 2;
            this.cboProductionOrder.Text = "Nhập lệnh sản xuất";
            // 
            // btnGuide
            // 
            this.btnGuide.Location = new System.Drawing.Point(700, 10);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(145, 29);
            this.btnGuide.TabIndex = 3;
            this.btnGuide.Text = "Hướng dẫn sử dụng";
            this.btnGuide.UseVisualStyleBackColor = true;
            // 
            // lblReceiverCode
            // 
            this.lblReceiverCode.AutoSize = true;
            this.lblReceiverCode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverCode.Location = new System.Drawing.Point(15, 50);
            this.lblReceiverCode.Name = "lblReceiverCode";
            this.lblReceiverCode.Size = new System.Drawing.Size(109, 19);
            this.lblReceiverCode.TabIndex = 4;
            this.lblReceiverCode.Text = "Mã người nhận";
            // 
            // cboReceiverCode
            // 
            this.cboReceiverCode.FormattingEnabled = true;
            this.cboReceiverCode.Location = new System.Drawing.Point(15, 72);
            this.cboReceiverCode.Name = "cboReceiverCode";
            this.cboReceiverCode.Size = new System.Drawing.Size(125, 28);
            this.cboReceiverCode.TabIndex = 5;
            // 
            // btnAddReceiver
            // 
            this.btnAddReceiver.Location = new System.Drawing.Point(145, 72);
            this.btnAddReceiver.Name = "btnAddReceiver";
            this.btnAddReceiver.Size = new System.Drawing.Size(30, 28);
            this.btnAddReceiver.TabIndex = 6;
            this.btnAddReceiver.Text = "+";
            this.btnAddReceiver.UseVisualStyleBackColor = true;
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.AutoSize = true;
            this.lblReceiverName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverName.Location = new System.Drawing.Point(190, 50);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(111, 19);
            this.lblReceiverName.TabIndex = 7;
            this.lblReceiverName.Text = "Tên người nhận";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(190, 72);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(250, 27);
            this.txtReceiverName.TabIndex = 8;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(15, 112);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(64, 19);
            this.lblDepartment.TabIndex = 11;
            this.lblDepartment.Text = "Bộ phận";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(15, 134);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(160, 28);
            this.cboDepartment.TabIndex = 12;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(190, 112);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(105, 19);
            this.lblReason.TabIndex = 13;
            this.lblReason.Text = "Lý do sản xuất";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(190, 134);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(250, 27);
            this.txtReason.TabIndex = 14;
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(15, 174);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(73, 19);
            this.lblAttachment.TabIndex = 17;
            this.lblAttachment.Text = "Kèm theo";
            // 
            // txtAttachmentCount
            // 
            this.txtAttachmentCount.Location = new System.Drawing.Point(15, 196);
            this.txtAttachmentCount.Name = "txtAttachmentCount";
            this.txtAttachmentCount.Size = new System.Drawing.Size(100, 27);
            this.txtAttachmentCount.TabIndex = 18;
            // 
            // lblOriginalDocument
            // 
            this.lblOriginalDocument.AutoSize = true;
            this.lblOriginalDocument.Location = new System.Drawing.Point(122, 199);
            this.lblOriginalDocument.Name = "lblOriginalDocument";
            this.lblOriginalDocument.Size = new System.Drawing.Size(99, 20);
            this.lblOriginalDocument.TabIndex = 19;
            this.lblOriginalDocument.Text = "Chứng từ gốc";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(245, 200);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(97, 19);
            this.lblReference.TabIndex = 20;
            this.lblReference.Text = "Tham chiếu...";
            // 
            // lblAccountingDate
            // 
            this.lblAccountingDate.AutoSize = true;
            this.lblAccountingDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountingDate.Location = new System.Drawing.Point(560, 50);
            this.lblAccountingDate.Name = "lblAccountingDate";
            this.lblAccountingDate.Size = new System.Drawing.Size(114, 19);
            this.lblAccountingDate.TabIndex = 9;
            this.lblAccountingDate.Text = "Ngày hạch toán";
            // 
            // dtpAccountingDate
            // 
            this.dtpAccountingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAccountingDate.Location = new System.Drawing.Point(560, 72);
            this.dtpAccountingDate.Name = "dtpAccountingDate";
            this.dtpAccountingDate.Size = new System.Drawing.Size(145, 27);
            this.dtpAccountingDate.TabIndex = 10;
            // 
            // lblDocumentDate
            // 
            this.lblDocumentDate.AutoSize = true;
            this.lblDocumentDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentDate.Location = new System.Drawing.Point(560, 112);
            this.lblDocumentDate.Name = "lblDocumentDate";
            this.lblDocumentDate.Size = new System.Drawing.Size(108, 19);
            this.lblDocumentDate.TabIndex = 15;
            this.lblDocumentDate.Text = "Ngày chứng từ";
            // 
            // dtpDocumentDate
            // 
            this.dtpDocumentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDocumentDate.Location = new System.Drawing.Point(560, 134);
            this.dtpDocumentDate.Name = "dtpDocumentDate";
            this.dtpDocumentDate.Size = new System.Drawing.Size(145, 27);
            this.dtpDocumentDate.TabIndex = 16;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(560, 174);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(89, 19);
            this.lblDocumentNumber.TabIndex = 21;
            this.lblDocumentNumber.Text = "Số chứng từ";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(560, 196);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(145, 27);
            this.txtDocumentNumber.TabIndex = 22;
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDetails.Location = new System.Drawing.Point(15, 240);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(99, 19);
            this.lblItemDetails.TabIndex = 23;
            this.lblItemDetails.Text = "Chi tiết vật tư";
            // 
            // dgvExportItems
            // 
            this.dgvExportItems.AllowUserToAddRows = false;
            this.dgvExportItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportItems.Location = new System.Drawing.Point(15, 264);
            this.dgvExportItems.Name = "dgvExportItems";
            this.dgvExportItems.RowHeadersWidth = 51;
            this.dgvExportItems.RowTemplate.Height = 24;
            this.dgvExportItems.Size = new System.Drawing.Size(1130, 280);
            this.dgvExportItems.TabIndex = 24;
            this.dgvExportItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExportItems_CellContentClick);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(15, 564);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(110, 32);
            this.btnAddRow.TabIndex = 25;
            this.btnAddRow.Text = "Thêm dòng";
            this.btnAddRow.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(135, 564);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(110, 32);
            this.btnDeleteRow.TabIndex = 26;
            this.btnDeleteRow.Text = "Xoá dòng";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1035, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 32);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ExportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(226)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.dgvExportItems);
            this.Controls.Add(this.lblItemDetails);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.lblDocumentNumber);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblOriginalDocument);
            this.Controls.Add(this.txtAttachmentCount);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.dtpDocumentDate);
            this.Controls.Add(this.lblDocumentDate);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.dtpAccountingDate);
            this.Controls.Add(this.lblAccountingDate);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.lblReceiverName);
            this.Controls.Add(this.btnAddReceiver);
            this.Controls.Add(this.cboReceiverCode);
            this.Controls.Add(this.lblReceiverCode);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.cboProductionOrder);
            this.Controls.Add(this.cboExportType);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExportControl";
            this.Size = new System.Drawing.Size(1160, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboExportType;
        private System.Windows.Forms.ComboBox cboProductionOrder;
        private System.Windows.Forms.Button btnGuide;

        private System.Windows.Forms.Label lblReceiverCode;
        private System.Windows.Forms.ComboBox cboReceiverCode;
        private System.Windows.Forms.Button btnAddReceiver;

        private System.Windows.Forms.Label lblReceiverName;
        private System.Windows.Forms.TextBox txtReceiverName;

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboDepartment;

        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;

        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtAttachmentCount;
        private System.Windows.Forms.Label lblOriginalDocument;
        private System.Windows.Forms.Label lblReference;

        private System.Windows.Forms.Label lblAccountingDate;
        private System.Windows.Forms.DateTimePicker dtpAccountingDate;

        private System.Windows.Forms.Label lblDocumentDate;
        private System.Windows.Forms.DateTimePicker dtpDocumentDate;

        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.TextBox txtDocumentNumber;

        private System.Windows.Forms.Label lblItemDetails;
        private System.Windows.Forms.DataGridView dgvExportItems;

        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnSave;
    }
}