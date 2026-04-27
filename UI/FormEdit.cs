using PPCOM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PPCOM.Services;

namespace PPCOM
{
    public partial class FormEdit : Form
    {
        int _roleId;
        int userId;
        public FormEdit(int id,string txtFullname, string txtEmail, int roleId)
        {
            InitializeComponent();
            userId = id;
            _roleId = roleId;
            textBox1.Text = txtFullname;
            textBox2.Text = txtEmail;
        }
        private UserService us = new UserService();

        private void FormEdit_Load(object sender, EventArgs e)
        {
            cbRole.DataSource = us.GetRoles();
            cbRole.DisplayMember = "role_name";
            cbRole.ValueMember = "role_id";

            cbRole.SelectedValue = _roleId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            us.UpdateUser(userId, textBox1.Text, textBox2.Text, (int)cbRole.SelectedValue);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
