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

namespace System_Weapon
{
    public partial class Location : Form
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public Location()
        {
            InitializeComponent();
        }

        private void ReadStudentData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open Connection
                connection.Open();

                // Query
                string query = "SELECT * FROM Locations";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(command);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

                connection.Close();
            }
        }

        private void LoadData()
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select data from the Owners table
                    string query = "SELECT * FROM Locations";

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataAdapter to fetch the data into a DataSet
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Locations");

                            // Bind the DataSet to the DataGridView
                            dataGridView1.DataSource = dataSet.Tables["Locations"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Log Out of the System?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                MainForm Lform = new MainForm();
                Lform.Show();
                this.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string LocationID = txtBoxLocationID.Text;
            string District = txtBoxDistrict.Text;
            string Village = txtBoxVillage.Text;
            string City = txtBoxCity.Text;
            string Description = txtBoxDesc.Text;
            string OwnerID = ComboBoxOwnerIDFK.SelectedItem?.ToString();  // Assuming ComboBoxOwnerIDFK contains OwnerID

            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(District) || string.IsNullOrWhiteSpace(Village) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Description) || string.IsNullOrWhiteSpace(OwnerID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to check if OwnerID already exists in Locations
                string checkQuery = $"SELECT COUNT(*) FROM Locations WHERE OwnerID = {OwnerID}";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("OwnerID is already assigned to another location. Please select a different owner or update the existing location.", "Duplicate OwnerID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Query to insert data into Locations with OwnerID
                        string query = "INSERT INTO Locations (District, Village, City, Descriptions, OwnerID) VALUES (@District, @Village, @City, @Description, @OwnerID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Use parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@District", District);
                            command.Parameters.AddWithValue("@Village", Village);
                            command.Parameters.AddWithValue("@City", City);
                            command.Parameters.AddWithValue("@Description", Description);
                            command.Parameters.AddWithValue("@OwnerID", OwnerID);

                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("Location is successfully saved");

                                // Clear text boxes and reset combo box
                                txtBoxLocationID.Clear();
                                txtBoxDistrict.Clear();
                                txtBoxVillage.Clear();
                                txtBoxCity.Clear();
                                txtBoxDesc.Clear();
                                ComboBoxOwnerIDFK.Text = "";

                                ReadStudentData();
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while saving the Locations info");
                            }
                        }
                    }
                }

                connection.Close();
            }


        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes and reset combo box
            txtBoxLocationID.Clear();
            txtBoxDistrict.Clear();
            txtBoxVillage.Clear();
            txtBoxCity.Clear();
            txtBoxDesc.Clear();
            ComboBoxOwnerIDFK.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string LocationID = txtBoxLocationID.Text;
            string District = txtBoxDistrict.Text;
            string Village = txtBoxVillage.Text;
            string City = txtBoxCity.Text;
            string Description = txtBoxDesc.Text;
            int SelectedOwnerID = Convert.ToInt32(ComboBoxOwnerIDFK.SelectedItem);  // Assuming ComboBoxOwnerIDFK contains OwnerID

            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(LocationID) || string.IsNullOrWhiteSpace(District) || string.IsNullOrWhiteSpace(Village) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Description) || ComboBoxOwnerIDFK.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to check if OwnerID already exists in Locations (excluding the current LocationID being updated)
                string checkQuery = $"SELECT COUNT(*) FROM Locations WHERE OwnerID = {SelectedOwnerID} AND LocationID != {LocationID}";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("OwnerID is already assigned to another location. Please select a different owner or update the existing location.", "Duplicate OwnerID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Query to update data in Locations with OwnerID
                        string query = "UPDATE Locations SET District = @District, Village = @Village, City = @City, Descriptions = @Description, OwnerID = @OwnerID WHERE LocationID = @LocationID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Use parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@LocationID", LocationID);
                            command.Parameters.AddWithValue("@District", District);
                            command.Parameters.AddWithValue("@Village", Village);
                            command.Parameters.AddWithValue("@City", City);
                            command.Parameters.AddWithValue("@Description", Description);
                            command.Parameters.AddWithValue("@OwnerID", SelectedOwnerID);

                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("Location is successfully updated");

                                // Clear text boxes and reset combo box
                                txtBoxLocationID.Clear();
                                txtBoxDistrict.Clear();
                                txtBoxVillage.Clear();
                                txtBoxCity.Clear();
                                txtBoxDesc.Clear();
                                ComboBoxOwnerIDFK.Text = "";

                                ReadStudentData();
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while updating the Locations info");
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string LocationID = txtBoxLocationID.Text;

            // Check if LocationID is empty
            if (string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please select a location to delete", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the OwnerID is associated with any location
                string checkQuery = $"SELECT COUNT(*) FROM Locations WHERE LocationID = {LocationID}";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount == 0)
                    {
                        MessageBox.Show("Location not found. Please select a valid location.", "Location Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Proceed with the deletion
                        string query = "DELETE FROM Locations WHERE LocationID = @LocationID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Use parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@LocationID", LocationID);

                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("Location is successfully deleted");

                                // Clear text boxes and reset combo box
                                txtBoxLocationID.Clear();
                                txtBoxDistrict.Clear();
                                txtBoxVillage.Clear();
                                txtBoxCity.Clear();
                                txtBoxDesc.Clear();
                                ComboBoxOwnerIDFK.Text = "";

                                ReadStudentData();
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while deleting the location");
                            }
                        }
                    }
                }

                connection.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate text boxes with selected row data
                txtBoxLocationID.Text = selectedRow.Cells["LocationID"].Value.ToString();
                txtBoxDistrict.Text = selectedRow.Cells["District"].Value.ToString();
                txtBoxVillage.Text = selectedRow.Cells["Village"].Value.ToString();
                txtBoxCity.Text = selectedRow.Cells["City"].Value.ToString();
                txtBoxDesc.Text = selectedRow.Cells["Descriptions"].Value.ToString();
                ComboBoxOwnerIDFK.Text = selectedRow.Cells["OwnerID"].Value.ToString();
            }
        }

        private void Location_Load(object sender, EventArgs e)
        {
            // Set the selection mode to FullRowSelect
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // combobox Data View

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT OwnerID FROM Owners";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandText = query;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        rd.GetInt32(0);
                        ComboBoxOwnerIDFK.Items.Add(rd.GetInt32(0));
                    }
                }
            }
            // Load data into the DataGridView when the form loads
            LoadData();
        }

        private void ComboBoxOwnerIDFK_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
