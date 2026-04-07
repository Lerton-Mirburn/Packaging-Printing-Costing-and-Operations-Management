namespace PPCOM.Controls
{
    partial class PurchaseListControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEnableCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeleteCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeactivateCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditCol,
            this.btnEnableCol,
            this.btnDeleteCol,
            this.btnDeactivateCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 525);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnEditCol
            // 
            this.btnEditCol.HeaderText = "";
            this.btnEditCol.Name = "btnEditCol";
            this.btnEditCol.Width = 40;
            // 
            // btnEnableCol
            // 
            this.btnEnableCol.HeaderText = "";
            this.btnEnableCol.Name = "btnEnableCol";
            this.btnEnableCol.Width = 40;
            // 
            // btnDeleteCol
            // 
            this.btnDeleteCol.HeaderText = "";
            this.btnDeleteCol.Name = "btnDeleteCol";
            this.btnDeleteCol.Width = 40;
            // 
            // btnDeactivateCol
            // 
            this.btnDeactivateCol.HeaderText = "";
            this.btnDeactivateCol.Name = "btnDeactivateCol";
            this.btnDeactivateCol.Width = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 44);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Tìm kiếm đơn mua hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH MUA HÀNG";
            // 
            // PurchaseListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseListControl";
            this.Size = new System.Drawing.Size(819, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn btnEditCol;
        private System.Windows.Forms.DataGridViewImageColumn btnEnableCol;
        private System.Windows.Forms.DataGridViewImageColumn btnDeleteCol;
        private System.Windows.Forms.DataGridViewImageColumn btnDeactivateCol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
