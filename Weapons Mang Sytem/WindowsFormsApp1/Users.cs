using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Edit(bool value)
        {
            txtBoxName.Enabled = value;
            txtBoxEmail.Enabled = value;
            txtBoxUsername.Enabled = value;
            txtBoxpassword.Enabled = value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               Edit(false );
                adminsBindingSource.EndEdit();
                adminsTableAdapter.Update(adminData.Admins);
                dataGridView1.Refresh();
                txtBoxName.Focus();
                txtBoxEmail.Focus();
                txtBoxUsername.Focus();
                txtBoxpassword.Focus();

                MessageBox.Show("User Successefully Saved.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminData.Admins.RejectChanges();
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.adminsTableAdapter.Fill(this.adminData.Admins);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure want to Delete this Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                adminsBindingSource.RemoveCurrent();
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Edit(true );
            txtBoxName.Focus();
            txtBoxEmail.Focus();
            txtBoxUsername.Focus();
            txtBoxpassword.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxEmail.Clear();
            txtBoxUsername.Clear();
            txtBoxpassword.Clear();
        }
    }
}
