using PPCOM.Data;
using PPCOM.Models;
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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PPCOM
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        private UserService us = new UserService();
        private void FormAdd_Load(object sender, EventArgs e)
        {
            cbRole.DataSource = us.GetRoles();   
            cbRole.DisplayMember = "role_name";
            cbRole.ValueMember = "role_id";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            us.AddUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, (int)cbRole.SelectedValue);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
