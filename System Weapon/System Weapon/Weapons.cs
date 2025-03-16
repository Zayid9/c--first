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
    public partial class Weapons : Form
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";
        public Weapons()
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
                string query = "SELECT * FROM Weapons";

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
                    string query = "SELECT * FROM Weapons";

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataAdapter to fetch the data into a DataSet
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Weapons");

                            // Bind the DataSet to the DataGridView
                            dataGridView1.DataSource = dataSet.Tables["Weapons"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ComboBoxOwnerIDFK_SelectedIndexChanged(object sender, EventArgs e)
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
            try
            {
                // Get values from input fields
                string weaponName = txtBoxWeaponName.Text;
                string manufacturerNo = txtBoxManuNo.Text;
                string madeIn = txtBoxMadeIn.Text;
                DateTime year = dateTimePicker1.Value;
                string description = txtBoxDes.Text;
                string categoryID = comboBoxCatIDFK.SelectedItem?.ToString(); // Assuming comboBoxCatIDFK contains CategoryID

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(weaponName) || string.IsNullOrWhiteSpace(manufacturerNo) ||
                    string.IsNullOrWhiteSpace(madeIn) || comboBoxCatIDFK.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if CategoryID is already assigned to another record
                    string checkDuplicateCategoryQuery = "SELECT COUNT(*) FROM Weapons WHERE CategoryID = @CategoryID";
                    using (SqlCommand checkDuplicateCategoryCommand = new SqlCommand(checkDuplicateCategoryQuery, connection))
                    {
                        checkDuplicateCategoryCommand.Parameters.AddWithValue("@CategoryID", categoryID);

                        int duplicateCategoryCount = (int)checkDuplicateCategoryCommand.ExecuteScalar();

                        if (duplicateCategoryCount > 0)
                        {
                            MessageBox.Show("Selected CategoryID is already assigned to another record. Please choose a different CategoryID.", "Duplicate CategoryID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new record
                    string saveQuery = @"INSERT INTO Weapons (WeaponName, ManufacturerNo, MadeIn, Year, Description, CategoryID) 
                                VALUES (@WeaponName, @ManufacturerNo, @MadeIn, @Year, @Description, @CategoryID)";

                    using (SqlCommand saveCommand = new SqlCommand(saveQuery, connection))
                    {
                        saveCommand.Parameters.AddWithValue("@WeaponName", weaponName);
                        saveCommand.Parameters.AddWithValue("@ManufacturerNo", manufacturerNo);
                        saveCommand.Parameters.AddWithValue("@MadeIn", madeIn);
                        saveCommand.Parameters.AddWithValue("@Year", year);
                        saveCommand.Parameters.AddWithValue("@Description", description);
                        saveCommand.Parameters.AddWithValue("@CategoryID", categoryID);

                        int result = saveCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Weapon information saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear text boxes and reset combo box
                            txtBoxWeaponName.Clear();
                            txtBoxManuNo.Clear();
                            txtBoxMadeIn.Clear();
                            dateTimePicker1.Value = DateTime.Now; // Reset the date to the current date/time
                            txtBoxDes.Clear();
                            comboBoxCatIDFK.SelectedIndex = -1; // Reset the selected index of the combo box

                            // Reload data after save
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while saving the Weapon information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate text boxes with selected row data
                txtBoxWeaponID.Text = selectedRow.Cells["WeaponID"].Value.ToString();
                txtBoxWeaponName.Text = selectedRow.Cells["WeaponName"].Value.ToString();
                txtBoxMadeIn.Text = selectedRow.Cells["MadeIn"].Value.ToString();
                txtBoxManuNo.Text = selectedRow.Cells["ManufacturerNo"].Value.ToString();

                // Validate and convert the "Year" cell value to DateTime
                if (DateTime.TryParse(selectedRow.Cells["Year"].Value.ToString(), out DateTime yearValue))
                {
                    dateTimePicker1.Value = yearValue;
                }
                else
                {
                    // Handle the case where the value is not a valid DateTime
                    // You can set a default value or display an error message
                    MessageBox.Show("Invalid date format in the 'Year' cell.");
                }

                txtBoxDes.Text = selectedRow.Cells["Description"].Value.ToString();
                comboBoxCatIDFK.Text = selectedRow.Cells["CategoryID"].Value.ToString();
            }
        }


        private void Weapons_Load(object sender, EventArgs e)
        {
            // Set the selection mode to FullRowSelect
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // combobox Data View

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT CategoryID FROM Categories";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandText = query;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        rd.GetInt32(0);
                        comboBoxCatIDFK.Items.Add(rd.GetInt32(0));
                    }
                }
            }
            // Load data into the DataGridView when the form loads
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input fields
                int weaponID;
                if (int.TryParse(txtBoxWeaponID.Text, out weaponID))
                {
                    string weaponName = txtBoxWeaponName.Text;
                    string manufacturerNo = txtBoxManuNo.Text;
                    string madeIn = txtBoxMadeIn.Text;
                    DateTime year = dateTimePicker1.Value;
                    string description = txtBoxDes.Text;
                    string categoryID = comboBoxCatIDFK.SelectedItem?.ToString(); // Assuming comboBoxCatIDFK contains CategoryID

                    // Check if any of the required fields is empty
                    if (string.IsNullOrWhiteSpace(weaponName) || string.IsNullOrWhiteSpace(manufacturerNo) ||
                        string.IsNullOrWhiteSpace(madeIn) || comboBoxCatIDFK.SelectedItem == null)
                    {
                        MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if CategoryID is already assigned to another record excluding the current one
                        string checkDuplicateCategoryQuery = "SELECT COUNT(*) FROM Weapons WHERE CategoryID = @CategoryID AND WeaponID != @WeaponID";
                        using (SqlCommand checkDuplicateCategoryCommand = new SqlCommand(checkDuplicateCategoryQuery, connection))
                        {
                            checkDuplicateCategoryCommand.Parameters.AddWithValue("@CategoryID", categoryID);
                            checkDuplicateCategoryCommand.Parameters.AddWithValue("@WeaponID", weaponID);

                            int duplicateCategoryCount = (int)checkDuplicateCategoryCommand.ExecuteScalar();

                            if (duplicateCategoryCount > 0)
                            {
                                MessageBox.Show("Selected CategoryID is already assigned to another record. Please choose a different CategoryID.", "Duplicate CategoryID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        // Update record
                        string updateQuery = @"UPDATE Weapons 
                                    SET WeaponName = @WeaponName, ManufacturerNo = @ManufacturerNo, 
                                        MadeIn = @MadeIn, Year = @Year, Description = @Description, 
                                        CategoryID = @CategoryID 
                                    WHERE WeaponID = @WeaponID";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@WeaponID", weaponID);
                            updateCommand.Parameters.AddWithValue("@WeaponName", weaponName);
                            updateCommand.Parameters.AddWithValue("@ManufacturerNo", manufacturerNo);
                            updateCommand.Parameters.AddWithValue("@MadeIn", madeIn);
                            updateCommand.Parameters.AddWithValue("@Year", year);
                            updateCommand.Parameters.AddWithValue("@Description", description);
                            updateCommand.Parameters.AddWithValue("@CategoryID", categoryID);

                            int result = updateCommand.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Weapon information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear text boxes and reset combo box
                                txtBoxWeaponID.Clear();
                                txtBoxWeaponName.Clear();
                                txtBoxMadeIn.Clear();
                                txtBoxManuNo.Clear();
                                dateTimePicker1.Value = DateTime.Now;
                                txtBoxDes.Clear();
                                comboBoxCatIDFK.SelectedIndex = -1;
                                
                                // Reload data after update
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while updating the Weapon information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid WeaponID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxWeaponID.Clear();
            txtBoxWeaponName.Clear();
            txtBoxMadeIn.Clear();
            txtBoxManuNo.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtBoxDes.Clear();
            comboBoxCatIDFK.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected WeaponID from the TextBox
                if (int.TryParse(txtBoxWeaponID.Text, out int weaponID))
                {
                    DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this weapon?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Check if the weaponID exists in the database
                            string checkExistenceQuery = "SELECT COUNT(*) FROM Weapons WHERE WeaponID = @WeaponID";
                            using (SqlCommand checkExistenceCommand = new SqlCommand(checkExistenceQuery, connection))
                            {
                                checkExistenceCommand.Parameters.AddWithValue("@WeaponID", weaponID);

                                int existenceCount = (int)checkExistenceCommand.ExecuteScalar();

                                if (existenceCount == 0)
                                {
                                    MessageBox.Show("Selected WeaponID does not exist in the database.", "Invalid WeaponID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            // Delete the record with the specified WeaponID
                            string deleteQuery = "DELETE FROM Weapons WHERE WeaponID = @WeaponID";
                            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@WeaponID", weaponID);

                                int result = deleteCommand.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Weapon information deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Clear text boxes and reset combo box
                                    
                                    txtBoxWeaponID.Clear();
                                    txtBoxWeaponName.Clear();
                                    txtBoxMadeIn.Clear();
                                    txtBoxManuNo.Clear();
                                    dateTimePicker1.Value = DateTime.Now;
                                    txtBoxDes.Clear();
                                    comboBoxCatIDFK.SelectedIndex = -1;
                                    
                                    // Reload data after delete
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("There was a problem while deleting the Weapon information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid WeaponID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}