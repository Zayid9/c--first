using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace System_Weapon
{
    public partial class LoginForm : Form
    {
        const string connection = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        private SqlConnection sqlConnection;

        public LoginForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

            // Wire up the KeyPress event for the password text box
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

        private void Admin_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = Admin_ShowPass.Checked ? '\0' : '*';
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Determine which text box raised the event
                if (sender == txtBoxUsername)
                {
                    // Move focus to the password text box
                    txtBoxPassword.Focus();
                }
                else if (sender == txtBoxPassword)
                {
                    // Simulate a click on the Login button
                    btnLogin.PerformClick();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            // Check if username and password are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform database authentication
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

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                sqlConnection.Open();

                // Perform the authentication query
                string query = "SELECT COUNT(*) FROM [Admin_Forms] WHERE Username = @Username AND Passwords = @Password";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0; // If count is greater than 0, authentication is successful
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
    }
}
