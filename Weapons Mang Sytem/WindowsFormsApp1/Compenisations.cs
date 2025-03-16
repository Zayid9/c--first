using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Compenisations : UserControl
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public Compenisations()
        {
            InitializeComponent();
        }

        private void ReadData()
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
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Compenisation");

                            // Ku dar DataSet-ka DataGridView
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Log Out of the System?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                MainForm Lform = new MainForm();
                this.Hide();
                Lform.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ComID = txtBoxComID.Text;
            string OwnerName = comboBoxOwnerIDFK.SelectedItem?.ToString(); 
            string WeaponPrice = txtBoxWeaponPrice.Text;
            string ComPrice = txtBoxComPrice.Text;
            string TakeOver = "Government";
            string Description = txtBoxDesc.Text;
            DateTime year = dateTimePicker1.Value;

            // Xaqiijin
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
                            return; // Stop
                        }
                    }

                    // Insert operation
                    string insertQuery = @"INSERT INTO Compenisation (OwnerID, ComPrice, WeaponPrice, TakeOver, Descriptions, Date_TakeOver)
                       VALUES ((SELECT OwnerID FROM Owners WHERE OwnerName = @OwnerName), @ComPrice, @WeaponPrice, @TakeOver, @Description, @Year)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@OwnerName", OwnerName);  
                        insertCommand.Parameters.AddWithValue("@ComPrice", ComPrice);
                        insertCommand.Parameters.AddWithValue("@WeaponPrice", WeaponPrice);
                        insertCommand.Parameters.AddWithValue("@TakeOver", TakeOver);
                        insertCommand.Parameters.AddWithValue("@Description", Description);
                        insertCommand.Parameters.AddWithValue("@Year", year);

                        var result = insertCommand.ExecuteNonQuery();

                        if (result != 0)
                        {
                            MessageBox.Show("Compenisation is Successfully Saved");

                            // Clear text boxes and reset combo box
                            txtBoxComID.Clear();
                            comboBoxOwnerIDFK.SelectedIndex = -1;
                            txtBoxWeaponPrice.Clear();
                            txtBoxComPrice.Clear();
                            txtBoxTakeOver.Clear();
                            txtBoxDesc.Clear();
                            dateTimePicker1.Value = DateTime.Now;

                            ReadData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while saving the Locations info");
                        }

                        // reload data after saving
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
            txtBoxComID.Clear();
            comboBoxOwnerIDFK.SelectedIndex = -1;
            txtBoxWeaponPrice.Clear();
            txtBoxComPrice.Clear();
            txtBoxTakeOver.Clear();
            txtBoxDesc.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int comID;
                if (int.TryParse(txtBoxComID.Text, out comID))
                {
                    string ownerName = comboBoxOwnerIDFK.SelectedItem?.ToString();
                    string weaponPrice = txtBoxWeaponPrice.Text;
                    string comPrice = txtBoxComPrice.Text;
                    string takeOver = txtBoxTakeOver.Text; 
                    string description = txtBoxDesc.Text;
                    DateTime year = dateTimePicker1.Value;

                    // Check if any of the required fields is empty
                    if (string.IsNullOrWhiteSpace(ownerName) || string.IsNullOrWhiteSpace(weaponPrice) ||
                        string.IsNullOrWhiteSpace(comPrice) || string.IsNullOrWhiteSpace(description))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Select 
                        string selectQuery = "SELECT OwnerID, ComPrice, WeaponPrice, TakeOver, Descriptions, Date_TakeOver FROM Compenisation WHERE ComID = @ComID";
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@ComID", comID);

                            SqlDataReader reader = selectCommand.ExecuteReader();

                            string currentOwnerID = string.Empty;
                            string currentComPrice = string.Empty;
                            string currentWeaponPrice = string.Empty;
                            string currentTakeOver = string.Empty;
                            string currentDescription = string.Empty;
                            DateTime currentYear = DateTime.Now;

                            if (reader.Read())
                            {
                                currentOwnerID = reader["OwnerID"].ToString();
                                currentComPrice = reader["ComPrice"].ToString();
                                currentWeaponPrice = reader["WeaponPrice"].ToString();
                                currentTakeOver = reader["TakeOver"].ToString();
                                currentDescription = reader["Descriptions"].ToString();
                                currentYear = Convert.ToDateTime(reader["Date_TakeOver"]);
                            }

                            reader.Close();

                            // Wax is bdl ah miyaa jira
                            bool changesMade = ownerName != currentOwnerID || comPrice != currentComPrice ||
                                               weaponPrice != currentWeaponPrice || takeOver != currentTakeOver ||
                                               description != currentDescription || year != currentYear;

                            if (!changesMade)
                            {
                                MessageBox.Show("No Changes Were Made. Please Make Any Update to Save Data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Update record
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
                                updateCommand.Parameters.AddWithValue("@OwnerName", ownerName);
                                updateCommand.Parameters.AddWithValue("@ComPrice", comPrice);
                                updateCommand.Parameters.AddWithValue("@WeaponPrice", weaponPrice);
                                updateCommand.Parameters.AddWithValue("@TakeOver", takeOver);
                                updateCommand.Parameters.AddWithValue("@Description", description);
                                updateCommand.Parameters.AddWithValue("@Year", year);
                                updateCommand.Parameters.AddWithValue("@ComID", comID);

                                int result = updateCommand.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Compenisation information Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Clear text boxes and reset combo box
                                    txtBoxComID.Clear();
                                    comboBoxOwnerIDFK.SelectedIndex = -1;
                                    txtBoxWeaponPrice.Clear();
                                    txtBoxComPrice.Clear();
                                    txtBoxTakeOver.Clear();
                                    txtBoxDesc.Clear();
                                    dateTimePicker1.Value = DateTime.Now;

                                    // Reload data after update
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("There was a problem while updating the Compenisation information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ComID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ComID = txtBoxComID.Text;

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
                            txtBoxComID.Clear();
                            comboBoxOwnerIDFK.SelectedIndex = -1;
                            txtBoxWeaponPrice.Clear();
                            txtBoxComPrice.Clear();
                            txtBoxTakeOver.Clear();
                            txtBoxDesc.Clear();
                            dateTimePicker1.Value = DateTime.Now;

                            ReadData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while deleting the Compenisation info");
                        }

                        // Reload data after deleting
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Compenisations_Load(object sender, EventArgs e)
        {
            string defaultTakeOver = "Government";

            // txtBox waxuu qaatay Default Value oo ah "Government" adga ma buuxineysidba
            txtBoxTakeOver.Text = defaultTakeOver;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // combobox Data View
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"Select ow.OwnerName from Owners as com
                                 Inner Join Owners as ow on ow.OwnerID = com.OwnerID;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        comboBoxOwnerIDFK.Items.Add(rd.GetString(0));
                    }
                }
            }

            // Load data into the DataGridView when the form loads
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtBoxComID.Text = selectedRow.Cells["ComID"].Value.ToString();
                comboBoxOwnerIDFK.Text = selectedRow.Cells["OwnerName"].Value.ToString();
                txtBoxWeaponPrice.Text = selectedRow.Cells["WeaponPrice"].Value.ToString();
                txtBoxComPrice.Text = selectedRow.Cells["ComPrice"].Value.ToString();

                txtBoxTakeOver.Text = selectedRow.Cells["TakeOver"].Value.ToString();
                txtBoxDesc.Text = selectedRow.Cells["Descriptions"].Value.ToString();

                if (DateTime.TryParse(selectedRow.Cells["Date_TakeOver"].Value.ToString(), out DateTime yearValue))
                {
                    dateTimePicker1.Value = yearValue;
                }
                else
                {
                    MessageBox.Show("Invalid date format in the 'Year' cell.");
                }

            }
        }
    }
}
