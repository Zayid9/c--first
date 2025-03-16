using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Weapon_System
{
    public partial class Form1 : Form
    {
        // Connection string
        private string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS;Initial Catalog=Weapons_System;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL command to check if the provided username and password exist in the 'admin' table
                    string query = "SELECT COUNT(*) FROM admin WHERE Username = @Username AND PasswordHash = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();
                        bool x = true;
                        if (x)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Opens The Dashboard

                            MainFrame mainFrame = new MainFrame();
                            mainFrame.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtBoxPassword.UseSystemPasswordChar = !chkBoxShowPassword.Checked;
            txtBoxPassword.PasswordChar = chkBoxShowPassword.Checked ? '\0' : '*';
        }

    }
}
