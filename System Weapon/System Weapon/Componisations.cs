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
    public partial class Componisations : UserControl
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";
        public Componisations()
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
                string query = "SELECT * FROM Compenisation";

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
                    string query = @"Select com.ComID, ow.OwnerName,com.ComPrice, com.WeaponPrice, com.TakeOver, com.Descriptions ,com.Date_TakeOver  from Compenisation as com
                                 Inner Join Owners as ow on ow.OwnerID = com.OwnerId";

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataAdapter to fetch the data into a DataSet
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Compenisation");

                            // Bind the DataSet to the DataGridView
                            dataGridView1.DataSource = dataSet.Tables["Compenisation"];
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate text boxes with selected row data
                txtBoxCompID.Text = selectedRow.Cells["ComID"].Value.ToString();
                comboBoxOwnerNameFK.Text = selectedRow.Cells["OwnerName"].Value.ToString();
                txtBoxWeaponPrice.Text = selectedRow.Cells["WeaponPrice"].Value.ToString();
                txtBoxComPrice.Text = selectedRow.Cells["ComPrice"].Value.ToString();

                txtBoxTakeOver.Text = selectedRow.Cells["TakeOver"].Value.ToString();
                txtBoxDes.Text = selectedRow.Cells["Descriptions"].Value.ToString();

                // Validate and convert the "Year" cell value to DateTime
                if (DateTime.TryParse(selectedRow.Cells["Date_TakeOver"].Value.ToString(), out DateTime yearValue))
                {
                    dateTimePicker1.Value = yearValue;
                }
                else
                {
                    // Handle the case where the value is not a valid DateTime
                    // You can set a default value or display an error message
                    MessageBox.Show("Invalid date format in the 'Year' cell.");
                }

            }
        }

        private void Componisations_Load(object sender, EventArgs e)
        {

            string defaultTakeOver = "Government";

            // Set the default value for txtBoxTakeOver
            txtBoxTakeOver.Text = defaultTakeOver;

            // Set the selection mode to FullRowSelect
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // combobox Data View
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"Select ow.OwnerName from Owners as com
                                 Inner Join Owners as ow on ow.OwnerID = com.OwnerID; ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        comboBoxOwnerNameFK.Items.Add(rd.GetString(0));
                    }
                }
            }

            // Load data into the DataGridView when the form loads
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ComID = txtBoxCompID.Text;
            string OwnerName = comboBoxOwnerNameFK.SelectedItem?.ToString();  // Assuming ComboBoxOwnerIDFK contains OwnerID
            string WeaponPrice = txtBoxWeaponPrice.Text;
            string ComPrice = txtBoxComPrice.Text;
            string TakeOver = "Government";
            string Description = txtBoxDes.Text;
            DateTime year = dateTimePicker1.Value;

            // Validate required fields
            if (string.IsNullOrEmpty(OwnerName) || string.IsNullOrEmpty(WeaponPrice) || string.IsNullOrEmpty(ComPrice) || string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the OwnerName already exists for another person
                    string checkQuery = "SELECT COUNT(*) FROM Compenisation WHERE OwnerID = (SELECT OwnerID FROM Owners WHERE OwnerName = @OwnerName)";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@OwnerName", OwnerName);

                        int ownerCount = (int)checkCommand.ExecuteScalar();

                        if (ownerCount > 0)
                        {
                            MessageBox.Show("OwnerName already exists for another person. Please choose a different OwnerName.");
                            return; // Stop further execution
                        }
                    }

                    // Insert operation
                    string insertQuery = @"INSERT INTO Compenisation (OwnerID, ComPrice, WeaponPrice, TakeOver, Descriptions, Date_TakeOver)
                       VALUES ((SELECT OwnerID FROM Owners WHERE OwnerName = @OwnerName), @ComPrice, @WeaponPrice, @TakeOver, @Description, @Year)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the insert SqlCommand
                        insertCommand.Parameters.AddWithValue("@OwnerName", OwnerName);  // You may not need this line if it's not required
                        insertCommand.Parameters.AddWithValue("@ComPrice", ComPrice);
                        insertCommand.Parameters.AddWithValue("@WeaponPrice", WeaponPrice);
                        insertCommand.Parameters.AddWithValue("@TakeOver", TakeOver);
                        insertCommand.Parameters.AddWithValue("@Description", Description);
                        insertCommand.Parameters.AddWithValue("@Year", year);

                        var result = insertCommand.ExecuteNonQuery();

                        if (result != 0)
                        {
                            MessageBox.Show("Compenisation is successfully Happens");

                            // Clear text boxes and reset combo box
                            txtBoxCompID.Clear();
                            comboBoxOwnerNameFK.SelectedIndex = -1;
                            txtBoxWeaponPrice.Clear();
                            txtBoxComPrice.Clear();
                            txtBoxTakeOver.Clear();
                            txtBoxDes.Clear();
                            dateTimePicker1.Value = DateTime.Now;

                            ReadStudentData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while saving the Locations info");
                        }

                        // Clear and reload data after saving
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxCompID.Clear();
            comboBoxOwnerNameFK.SelectedIndex = -1;
            txtBoxWeaponPrice.Clear();
            txtBoxComPrice.Clear();
            txtBoxTakeOver.Clear();
            txtBoxDes.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ComID = txtBoxCompID.Text;
            string OwnerName = comboBoxOwnerNameFK.SelectedItem?.ToString();
            string WeaponPrice = txtBoxWeaponPrice.Text;
            string ComPrice = txtBoxComPrice.Text;
            string TakeOver = txtBoxTakeOver.Text;
            string Description = txtBoxDes.Text;
            DateTime year = dateTimePicker1.Value;

            try
            {
                // Validate required fields
                if (string.IsNullOrEmpty(OwnerName) || string.IsNullOrEmpty(WeaponPrice) || string.IsNullOrEmpty(ComPrice) || string.IsNullOrEmpty(Description))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    // Check if the OwnerName already exists for another person
                    string checkQuery = "SELECT COUNT(*) FROM Compenisation WHERE OwnerID = (SELECT OwnerID FROM Owners WHERE OwnerName = @OwnerName) AND ComID <> @ComID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@OwnerName", OwnerName);
                        checkCommand.Parameters.AddWithValue("@ComID", ComID);

                        int ownerCount = (int)checkCommand.ExecuteScalar();

                        if (ownerCount > 0)
                        {
                            MessageBox.Show("OwnerName already exists for another person. Please choose a different OwnerName.");
                            return; // Stop further execution
                        }
                    }



                    // Update operation
                    string updateQuery = @"UPDATE Compenisation 
                                   SET OwnerID = (SELECT OwnerID FROM Owners WHERE OwnerName = @OwnerName),
                                       ComPrice = @ComPrice,
                                       WeaponPrice = @WeaponPrice,
                                       TakeOver = @TakeOver,
                                       Descriptions = @Description,
                                       Date_TakeOver = @Year
                                   WHERE ComID = @ComID";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the update SqlCommand
                        updateCommand.Parameters.AddWithValue("@OwnerName", OwnerName);  // You may not need this line if it's not required
                        updateCommand.Parameters.AddWithValue("@ComPrice", ComPrice);
                        updateCommand.Parameters.AddWithValue("@WeaponPrice", WeaponPrice);
                        updateCommand.Parameters.AddWithValue("@TakeOver", TakeOver);
                        updateCommand.Parameters.AddWithValue("@Description", Description);
                        updateCommand.Parameters.AddWithValue("@Year", year);
                        updateCommand.Parameters.AddWithValue("@ComID", ComID);

                        var result = updateCommand.ExecuteNonQuery();

                        if (result != 0)
                        {
                            MessageBox.Show("Compenisation is successfully updated");

                            // Clear text boxes and reset combo box
                            txtBoxCompID.Clear();
                            comboBoxOwnerNameFK.SelectedIndex = -1;
                            txtBoxWeaponPrice.Clear();
                            txtBoxComPrice.Clear();
                            txtBoxTakeOver.Clear();
                            txtBoxDes.Clear();
                            dateTimePicker1.Value = DateTime.Now;

                            ReadStudentData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while updating the Compenisation info");
                        }

                        // Clear and reload data after updating
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ComID = txtBoxCompID.Text;

            if (string.IsNullOrEmpty(ComID))
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete operation
                    string deleteQuery = "DELETE FROM Compenisation WHERE ComID = @ComID";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        // Add parameter to the delete SqlCommand
                        deleteCommand.Parameters.AddWithValue("@ComID", ComID);

                        var result = deleteCommand.ExecuteNonQuery();

                        if (result != 0)
                        {
                            MessageBox.Show("Compenisation is successfully deleted");

                            // Clear text boxes and reset combo box
                            txtBoxCompID.Clear();
                            comboBoxOwnerNameFK.SelectedIndex = -1;
                            txtBoxWeaponPrice.Clear();
                            txtBoxComPrice.Clear();
                            txtBoxTakeOver.Clear();
                            txtBoxDes.Clear();
                            dateTimePicker1.Value = DateTime.Now;

                            ReadStudentData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while deleting the Compenisation info");
                        }

                        // Clear and reload data after deleting
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
