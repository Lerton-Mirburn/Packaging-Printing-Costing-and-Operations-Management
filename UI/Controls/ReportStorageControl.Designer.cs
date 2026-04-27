using System.Drawing;

namespace PPCOM.Controls
{
    partial class ReportStorageControl
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
            this.lblTitile = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelItem1 = new System.Windows.Forms.Panel();
            this.picReportIcon = new System.Windows.Forms.PictureBox();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.panelItem1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReportIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitile.Location = new System.Drawing.Point(20, 15);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(231, 28);
            this.lblTitile.TabIndex = 0;
            this.lblTitile.Text = "Danh sách báo cáo kho";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(797, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập từ khoá tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(977, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panelItem1
            // 
            this.panelItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
            this.panelItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItem1.Controls.Add(this.lblItem1);
            this.panelItem1.Controls.Add(this.picReportIcon);
            this.panelItem1.Location = new System.Drawing.Point(28, 87);
            this.panelItem1.Name = "panelItem1";
            this.panelItem1.Size = new System.Drawing.Size(200, 200);
            this.panelItem1.TabIndex = 3;
            // 
            // picReportIcon
            // 
            this.picReportIcon.Location = new System.Drawing.Point(58, 33);
            this.picReportIcon.Name = "picReportIcon";
            this.picReportIcon.Size = new System.Drawing.Size(80, 80);
            this.picReportIcon.TabIndex = 0;
            this.picReportIcon.TabStop = false;
            this.picReportIcon.Click += new System.EventHandler(this.picReportIcon_Click);
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Location = new System.Drawing.Point(12, 142);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(183, 20);
            this.lblItem1.TabIndex = 1;
            this.lblItem1.Text = "Sổ chi tiết vật tư hàng hoá\r\n";
            // 
            // ReportStorageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.Controls.Add(this.panelItem1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportStorageControl";
            this.Size = new System.Drawing.Size(1160, 640);
            this.panelItem1.ResumeLayout(false);
            this.panelItem1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReportIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelItem1;
        private System.Windows.Forms.PictureBox picReportIcon;
        private System.Windows.Forms.Label lblItem1;
    }
}
