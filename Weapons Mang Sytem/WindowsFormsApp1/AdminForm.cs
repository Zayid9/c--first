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
    public partial class AdminForm : Form
    {
        private readonly SqlConnection conn = new SqlConnection(Properties.Settings.Default.WEAPONSConnectionString);

        public AdminForm()
        {
            InitializeComponent();

            // Wexey sameynesaa inaad Enter dhahdo adoona mouseka isticmlaan
            txtBoxUsername.KeyPress += TextBox_KeyPress;
            txtBoxPassword.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //  wxey cadeynesaa text box aad joogto sida loo focus gareyn lhaa
                if (sender == txtBoxUsername)
                {
                    txtBoxPassword.Focus();
                }
                else if (sender == txtBoxPassword)
                {
                    btnLogin.PerformClick();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admins WHERE Username=@Username AND Passwords=@Password", conn);
                cmd.Parameters.AddWithValue("@Username", txtBoxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtBoxPassword.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Please Check Your Username Or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Admin_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = Admin_ShowPass.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
