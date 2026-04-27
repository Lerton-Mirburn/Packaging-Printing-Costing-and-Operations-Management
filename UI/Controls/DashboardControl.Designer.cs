using System.Drawing;

namespace PPCOM.Controls
{
    partial class DashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnProcess = new Guna.UI2.WinForms.Guna2Button();
            this.btnCharts = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchaseOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchaseContracts = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchasing = new Guna.UI2.WinForms.Guna2Button();
            this.btnInvoiceEntry = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchaseReturns = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnOthers = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnOthers);
            this.guna2Panel1.Controls.Add(this.btnReports);
            this.guna2Panel1.Controls.Add(this.btnPurchaseReturns);
            this.guna2Panel1.Controls.Add(this.btnInvoiceEntry);
            this.guna2Panel1.Controls.Add(this.btnPurchasing);
            this.guna2Panel1.Controls.Add(this.btnPurchaseContracts);
            this.guna2Panel1.Controls.Add(this.btnPurchaseOrders);
            this.guna2Panel1.Controls.Add(this.btnCharts);
            this.guna2Panel1.Controls.Add(this.btnProcess);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1100, 45);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProcess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProcess.FillColor = System.Drawing.Color.Transparent;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProcess.ForeColor = System.Drawing.Color.Black;
            this.btnProcess.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnProcess.Location = new System.Drawing.Point(24, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(91, 40);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Quy trình";
            // 
            // btnCharts
            // 
            this.btnCharts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCharts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCharts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCharts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCharts.FillColor = System.Drawing.Color.Transparent;
            this.btnCharts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCharts.ForeColor = System.Drawing.Color.Black;
            this.btnCharts.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnCharts.Location = new System.Drawing.Point(121, 3);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(91, 40);
            this.btnCharts.TabIndex = 1;
            this.btnCharts.Text = "Biểu đồ";
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchaseOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchaseOrders.FillColor = System.Drawing.Color.Transparent;
            this.btnPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchaseOrders.ForeColor = System.Drawing.Color.Black;
            this.btnPurchaseOrders.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnPurchaseOrders.Location = new System.Drawing.Point(218, 3);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Size = new System.Drawing.Size(137, 40);
            this.btnPurchaseOrders.TabIndex = 2;
            this.btnPurchaseOrders.Text = "Đơn mua hàng";
            // 
            // btnPurchaseContracts
            // 
            this.btnPurchaseContracts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseContracts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseContracts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchaseContracts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchaseContracts.FillColor = System.Drawing.Color.Transparent;
            this.btnPurchaseContracts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchaseContracts.ForeColor = System.Drawing.Color.Black;
            this.btnPurchaseContracts.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnPurchaseContracts.Location = new System.Drawing.Point(361, 2);
            this.btnPurchaseContracts.Name = "btnPurchaseContracts";
            this.btnPurchaseContracts.Size = new System.Drawing.Size(168, 40);
            this.btnPurchaseContracts.TabIndex = 3;
            this.btnPurchaseContracts.Text = "Hợp đồng mua hàng";
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchasing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchasing.FillColor = System.Drawing.Color.Transparent;
            this.btnPurchasing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchasing.ForeColor = System.Drawing.Color.Black;
            this.btnPurchasing.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnPurchasing.Location = new System.Drawing.Point(535, 3);
            this.btnPurchasing.Name = "btnPurchasing";
            this.btnPurchasing.Size = new System.Drawing.Size(104, 40);
            this.btnPurchasing.TabIndex = 4;
            this.btnPurchasing.Text = "Mua hàng";
            // 
            // btnInvoiceEntry
            // 
            this.btnInvoiceEntry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoiceEntry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoiceEntry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoiceEntry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvoiceEntry.FillColor = System.Drawing.Color.Transparent;
            this.btnInvoiceEntry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInvoiceEntry.ForeColor = System.Drawing.Color.Black;
            this.btnInvoiceEntry.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnInvoiceEntry.Location = new System.Drawing.Point(645, 3);
            this.btnInvoiceEntry.Name = "btnInvoiceEntry";
            this.btnInvoiceEntry.Size = new System.Drawing.Size(129, 40);
            this.btnInvoiceEntry.TabIndex = 5;
            this.btnInvoiceEntry.Text = "Nhận Hóa Đơn";
            // 
            // btnPurchaseReturns
            // 
            this.btnPurchaseReturns.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseReturns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseReturns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchaseReturns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchaseReturns.FillColor = System.Drawing.Color.Transparent;
            this.btnPurchaseReturns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchaseReturns.ForeColor = System.Drawing.Color.Black;
            this.btnPurchaseReturns.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnPurchaseReturns.Location = new System.Drawing.Point(780, 3);
            this.btnPurchaseReturns.Name = "btnPurchaseReturns";
            this.btnPurchaseReturns.Size = new System.Drawing.Size(141, 40);
            this.btnPurchaseReturns.TabIndex = 6;
            this.btnPurchaseReturns.Text = "Trả lại hàng mua";
            // 
            // btnReports
            // 
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnReports.Location = new System.Drawing.Point(927, 2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(87, 40);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Báo cáo";
            // 
            // btnOthers
            // 
            this.btnOthers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOthers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOthers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOthers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOthers.FillColor = System.Drawing.Color.Transparent;
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOthers.ForeColor = System.Drawing.Color.Black;
            this.btnOthers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.btnOthers.Location = new System.Drawing.Point(1013, 2);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(87, 40);
            this.btnOthers.TabIndex = 8;
            this.btnOthers.Text = "Khác";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.Location = new System.Drawing.Point(24, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm tên chức năng";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(671, 35);
            this.txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chức Năng";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(24, 136);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(557, 295);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(598, 201);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(129, 146);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tình hình bán hàng ngày";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(24, 632);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(557, 122);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 8;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(745, 48);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(352, 731);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 9;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(24, 461);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(557, 140);
            this.guna2PictureBox5.TabIndex = 10;
            this.guna2PictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "TÌNH HÌNH BÁN HÀNG THEO NGÀY/ THÁNG CỦA  BẠN";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(226)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.guna2PictureBox4);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1100, 800);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnProcess;
        private Guna.UI2.WinForms.Guna2Button btnCharts;
        private Guna.UI2.WinForms.Guna2Button btnPurchaseContracts;
        private Guna.UI2.WinForms.Guna2Button btnPurchaseOrders;
        private Guna.UI2.WinForms.Guna2Button btnPurchasing;
        private Guna.UI2.WinForms.Guna2Button btnInvoiceEntry;
        private Guna.UI2.WinForms.Guna2Button btnPurchaseReturns;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnOthers;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label label3;
    }
}
