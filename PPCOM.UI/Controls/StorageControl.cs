using PPCOM.Services;
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
    public partial class StorageControl : UserControl
    {
        public StorageControl()
        {
            InitializeComponent();
            txtSearch.Text = "Nhập từ khoá tìm kiếm";
            txtSearch.ForeColor = Color.Gray;
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập từ khoá tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Nhập từ khoá tìm kiếm";
                txtSearch.ForeColor = Color.Gray;
            }
        }

    }
}
