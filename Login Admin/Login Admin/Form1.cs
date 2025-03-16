using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set KeyPreview property to true
            this.KeyPreview = true;

            // Attach the KeyDown event handler
            this.KeyDown += Form1_KeyDown;
        }

        public string conString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False;Initial Catalog=ADMIN_LOGIN";

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call the login method when Enter key is pressed
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        string query = "SELECT COUNT(*) FROM LOGIN_ADMIN WHERE USERNAME = @Username AND PASSWORD = @Password";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Use parameters to prevent SQL injection
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show("Login successful");

                                // Open Add_or_Register_Weapon form
                                Add_or_Register_Weapon x = new Add_or_Register_Weapon();
                                x.ShowDialog();

                                
                                this.Hide(); 
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


    }
}
