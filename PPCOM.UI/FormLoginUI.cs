using System;
using System.Windows.Forms;
using PPCOM.UI.Controls;

namespace LoginSystem
{
    public partial class FormLoginUI : Form
    {
        public FormLoginUI()
        {
            InitializeComponent();
            LoadUserControl(new ucLogin());
        }

        public void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;

            if (pnlAuthContainer.Controls.Count > 0)
            {
                var oldControl = pnlAuthContainer.Controls[0];
                pnlAuthContainer.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

            pnlAuthContainer.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}