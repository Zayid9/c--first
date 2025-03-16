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
    public partial class State : Form
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";
        public State()
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
                string query = "SELECT * FROM States";

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
                    string query = "SELECT * FROM States";

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataAdapter to fetch the data into a DataSet
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "States");

                            // Bind the DataSet to the DataGridView
                            dataGridView1.DataSource = dataSet.Tables["States"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            string StateID = txtBoxStateID.Text;
            string StateName = txtBoxStateName.Text;
            string LocationID = comboBoxLocationID.SelectedItem?.ToString();

            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(StateName) || string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to check if LocationID already exists in States
                string checkQuery = $"SELECT COUNT(*) FROM States WHERE LocationID = {LocationID}";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("LocationID is already assigned to another state. Please select a different location or update the existing state.", "Duplicate LocationID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Query to insert data into States
                        string query = "INSERT INTO States (StateName, LocationID) VALUES (@StateName, @LocationID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Use parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@StateName", StateName);
                            command.Parameters.AddWithValue("@LocationID", LocationID);

                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("State is successfully saved");

                                // Clear text boxes and reset combo box
                                txtBoxStateID.Clear();
                                txtBoxStateName.Clear();
                                comboBoxLocationID.Items.Clear();
                                comboBoxLocationID.Text = "";  // Clear the selected item in the combo box

                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while saving the State info");
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
            txtBoxStateID.Clear();
            txtBoxStateName.Clear();
            comboBoxLocationID.Items.Clear();
            comboBoxLocationID.Text = "";  // Clear the selected item in the combo box
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string StateID = txtBoxStateID.Text;
            string StateName = txtBoxStateName.Text;
            string LocationID = comboBoxLocationID.SelectedItem?.ToString();

            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(StateID) || string.IsNullOrWhiteSpace(StateName) || string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to check if LocationID already exists in States for other states (excluding the current one being updated)
                string checkQuery = $"SELECT COUNT(*) FROM States WHERE LocationID = @LocationID AND StateID != @StateID";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@LocationID", LocationID);
                    checkCommand.Parameters.AddWithValue("@StateID", StateID);

                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("LocationID is already assigned to another state. Please select a different location or update the existing state.", "Duplicate LocationID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Query to update data in States
                        string query = "UPDATE States SET StateName = @StateName, LocationID = @LocationID WHERE StateID = @StateID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Use parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@StateName", StateName);
                            command.Parameters.AddWithValue("@LocationID", LocationID);
                            command.Parameters.AddWithValue("@StateID", StateID);


                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("State is successfully updated");

                                // Clear text boxes and reset combo box
                                txtBoxStateID.Clear();
                                txtBoxStateName.Clear();
                                comboBoxLocationID.Items.Clear();
                                comboBoxLocationID.Text = "";  // Clear the selected item in the combo box

                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while updating the State info");
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string StateID = txtBoxStateID.Text;
            string StateName = txtBoxStateName.Text;
            string LocationID = comboBoxLocationID.SelectedItem?.ToString();

            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(StateID) || string.IsNullOrWhiteSpace(StateName) || string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this state?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;  // User canceled the deletion
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to delete data from States
                string query = "DELETE FROM States WHERE StateID = @StateID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@StateID", StateID);

                    var deleteResult = command.ExecuteNonQuery();

                    if (deleteResult != 0)
                    {
                        MessageBox.Show("State is successfully deleted");

                        // Clear text boxes and reset combo box
                        txtBoxStateID.Clear();
                        txtBoxStateName.Clear();
                        comboBoxLocationID.Items.Clear();
                        comboBoxLocationID.Text = "";  // Clear the selected item in the combo box

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("There was a problem while deleting the State info");
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
                txtBoxStateID.Text = selectedRow.Cells["StateID"].Value.ToString();
                txtBoxStateName.Text = selectedRow.Cells["StateName"].Value.ToString();
                comboBoxLocationID.Text = selectedRow.Cells["LocationID"].Value.ToString();

            }
        }

        private void State_Load(object sender, EventArgs e)
        {
            // Set the selection mode to FullRowSelect
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            // ComboBoxLocationID Data View
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string queryLocation = @"SELECT LocationID FROM Locations";

                using (SqlCommand cmd = new SqlCommand(queryLocation, con))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        int locationID = rd.GetInt32(0);
                        comboBoxLocationID.Items.Add(locationID);
                    }
                }
            }

            // Load data into the DataGridView when the form loads
            LoadData();
        }
    }
}
