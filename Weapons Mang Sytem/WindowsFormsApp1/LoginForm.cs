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
    public partial class LoginForm : Form
    {
        const string connection = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        private SqlConnection sqlConnection;

        public LoginForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

            // Wexey sameynesaa inaad Enter dhahdo adoona mouseka isticmlaan
            txtBoxUsername.KeyPress += TextBox_KeyPress;
            txtBoxPassword.KeyPress += TextBox_KeyPress;
        }

        private void InitializeDatabaseConnection()
        {
            sqlConnection = new SqlConnection(connection);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                sqlConnection.Open();

                // Wxey xaqiijineysaa queryga
                string query = "SELECT COUNT(*) FROM [Admin_Forms] WHERE Username = @Username AND Passwords = @Password";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0; // hduu count-ga uu ka weynaado 0 , authenticationka waa saxmay mrkas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Admin_ShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = Admin_ShowPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            // Wxey xaqiijinayaan iney banantahy username iyo passwordka
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hdii uu saxmo authentication waa loo ogalanayaa hdii klena waa qldnthy baa la leyhy
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
            this.Hide();
        }
    }
}
