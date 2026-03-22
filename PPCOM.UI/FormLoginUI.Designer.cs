namespace LoginSystem
{
    partial class FormLoginUI
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
            this.pnlAuthContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAuthContainer
            // 
            this.pnlAuthContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAuthContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlAuthContainer.Name = "pnlAuthContainer";
            this.pnlAuthContainer.Size = new System.Drawing.Size(806, 453);
            this.pnlAuthContainer.TabIndex = 0;
            // 
            // FormLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 453);
            this.Controls.Add(this.pnlAuthContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLoginUI";
            this.Text = "FormLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAuthContainer;
    }
}