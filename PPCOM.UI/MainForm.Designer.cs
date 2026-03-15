namespace PPCOM
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.PictureMenu = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnProduce = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pictureLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1776, 108);
            this.panelTop.TabIndex = 38;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(13, 18);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(77, 80);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 942);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1776, 108);
            this.panelBottom.TabIndex = 39;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelContent);
            this.panelBody.Controls.Add(this.panelSidebar);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 108);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1776, 834);
            this.panelBody.TabIndex = 40;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(360, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1416, 834);
            this.panelContent.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelSidebar.Controls.Add(this.PictureMenu);
            this.panelSidebar.Controls.Add(this.textBox1);
            this.panelSidebar.Controls.Add(this.btnEmployee);
            this.panelSidebar.Controls.Add(this.btnReport);
            this.panelSidebar.Controls.Add(this.btnCalculate);
            this.panelSidebar.Controls.Add(this.btnPay);
            this.panelSidebar.Controls.Add(this.btnOrder);
            this.panelSidebar.Controls.Add(this.btnEstimate);
            this.panelSidebar.Controls.Add(this.btnProduce);
            this.panelSidebar.Controls.Add(this.btnStorage);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(360, 834);
            this.panelSidebar.TabIndex = 33;
            // 
            // PictureMenu
            // 
            this.PictureMenu.Location = new System.Drawing.Point(20, 20);
            this.PictureMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureMenu.Name = "PictureMenu";
            this.PictureMenu.Size = new System.Drawing.Size(48, 49);
            this.PictureMenu.TabIndex = 1;
            this.PictureMenu.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 26);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "Tìm kiếm";
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(20, 151);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(303, 52);
            this.btnEmployee.TabIndex = 18;
            this.btnEmployee.Text = "Quản lý và phân quyền người dùng";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(20, 603);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(303, 52);
            this.btnReport.TabIndex = 24;
            this.btnReport.Text = "Báo cáo và thống kê";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 226);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(303, 52);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Tính và lập báo giá sản phẩm";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(20, 528);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(303, 52);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "Quản lý công nợ và Thanh toán ";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(20, 302);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(303, 52);
            this.btnOrder.TabIndex = 20;
            this.btnOrder.Text = "Quản lý mua hàng";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(20, 678);
            this.btnEstimate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(303, 52);
            this.btnEstimate.TabIndex = 25;
            this.btnEstimate.Text = "Định mức vật tư và Bù hao";
            this.btnEstimate.UseVisualStyleBackColor = true;
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(20, 377);
            this.btnProduce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(303, 52);
            this.btnProduce.TabIndex = 21;
            this.btnProduce.Text = "Quản lý sản xuất";
            this.btnProduce.UseVisualStyleBackColor = true;
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(20, 452);
            this.btnStorage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(303, 52);
            this.btnStorage.TabIndex = 22;
            this.btnStorage.Text = "Quản lý kho";
            this.btnStorage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1776, 1050);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox PictureMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.Button btnStorage;
    }
}