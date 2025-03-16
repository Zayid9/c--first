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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Weapon_System
{
    public partial class Owner : UserControl
    {
        // Connection string
        private string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS;Initial Catalog=Weapons_System;Integrated Security=True";


        public Owner()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string OwnerID = txtBoxOwnerID.Text.Trim();
            string Name = txtBoxName.Text.Trim();
            string Tell = txtBoxTell.Text.Trim();
            string Sex = ComboboxSex.Text.Trim();
            string Location = txtBoxLocationID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(OwnerID) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Tell) || string.IsNullOrEmpty(Sex) || string.IsNullOrEmpty(Location))
            {
                MessageBox.Show("Please Fill Blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL command to insert data into the 'population' table
                    string query = "INSERT INTO population (pop_no, name, tell, sex, loc_no) VALUES (@OwnerID, @Name, @Tell, @Sex, @Location)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@OwnerID", OwnerID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Tell", Tell);
                        command.Parameters.AddWithValue("@Sex", Sex);
                        command.Parameters.AddWithValue("@Location", Location);

                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Saved successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string OwnerID = txtBoxOwnerID.Text.Trim();
            string Name = txtBoxName.Text.Trim();
            string Tell = txtBoxTell.Text.Trim();
            string Sex = ComboboxSex.Text.Trim();
            string Location = txtBoxLocationID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(OwnerID) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Tell) || string.IsNullOrEmpty(Sex) || string.IsNullOrEmpty(Location))
            {
                MessageBox.Show("Please Fill Blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL command to update data in the 'population' table
                    string query = "UPDATE population SET name = @Name, tell = @Tell, sex = @Sex, loc_no = @Location WHERE pop_no = @OwnerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@OwnerID", OwnerID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Tell", Tell);
                        command.Parameters.AddWithValue("@Sex", Sex);
                        command.Parameters.AddWithValue("@Location", Location);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("No matching record found for the provided OwnerID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes and combobox
            txtBoxOwnerID.Clear();
            txtBoxName.Clear();
            txtBoxTell.Clear();
            ComboboxSex.SelectedIndex = -1; // Assuming you want to clear the selection
            txtBoxLocationID.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ownerID = txtBoxOwnerID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(ownerID))
            {
                MessageBox.Show("Please provide an OwnerID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Database connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // SQL command to delete data from the 'population' table
                        string query = "DELETE FROM population WHERE pop_no = @OwnerID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the query
                            command.Parameters.AddWithValue("@OwnerID", ownerID);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Deletion successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear the input fields
                            }
                            else
                            {
                                MessageBox.Show("No matching record found for the provided OwnerID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL command to select all data from the 'population' table
                    string query = "SELECT * FROM population";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ComboboxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}