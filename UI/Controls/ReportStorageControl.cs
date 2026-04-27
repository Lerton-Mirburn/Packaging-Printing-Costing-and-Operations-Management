using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPCOM.Controls
{
    public partial class ReportStorageControl : UserControl
    {
        public ReportStorageControl()
        {
            InitializeComponent();
        }

        private void picReportIcon_Click(object sender, EventArgs e)
        {
            LoadPage(new DetailReportControl());
        }
        private void LoadPage(UserControl page)
        {
            this.Controls.Clear();
            page.Dock = DockStyle.Fill;
            this.Controls.Add(page);
        }
    }
}
