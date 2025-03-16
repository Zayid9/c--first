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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Weapons";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Weapons");

                            // Ku dhaji DataSet-ka DataGridView
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
            try
            {
                string weaponName = txtBoxWeaponName.Text;
                string manufacturerNo = txtBoxManufacturerNo.Text;
                string madeIn = txtBoxMadeIn.Text;
                DateTime year = dateTimePicker1.Value;
                string description = txtBoxDesc.Text;
                string categoryID = comboBoxCategoryIDFK.SelectedItem?.ToString(); 

                // Hubinta
                if (string.IsNullOrWhiteSpace(weaponName) || string.IsNullOrWhiteSpace(manufacturerNo) ||
                    string.IsNullOrWhiteSpace(madeIn) || comboBoxCategoryIDFK.SelectedItem == null)
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
                            txtBoxManufacturerNo.Clear();
                            txtBoxMadeIn.Clear();
                            dateTimePicker1.Value = DateTime.Now; // Wxey ka dhigeysaa date ka manta la joogo
                            txtBoxDesc.Clear();
                            comboBoxCategoryIDFK.SelectedIndex = -1; // Waa qaab kle oo loo ga tiro data-da combobox ka

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxWeaponID.Clear();
            txtBoxWeaponName.Clear();
            txtBoxMadeIn.Clear();
            txtBoxManufacturerNo.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtBoxDesc.Clear();
            comboBoxCategoryIDFK.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int weaponID;
                if (int.TryParse(txtBoxWeaponID.Text, out weaponID))
                {
                    string weaponName = txtBoxWeaponName.Text;
                    string manufacturerNo = txtBoxManufacturerNo.Text;
                    string madeIn = txtBoxMadeIn.Text;
                    DateTime year = dateTimePicker1.Value;
                    string description = txtBoxDesc.Text;
                    string categoryID = comboBoxCategoryIDFK.SelectedItem?.ToString();

                    // Check if any of the required fields is empty
                    if (string.IsNullOrWhiteSpace(weaponName) || string.IsNullOrWhiteSpace(manufacturerNo) ||
                        string.IsNullOrWhiteSpace(madeIn) || comboBoxCategoryIDFK.SelectedItem == null)
                    {
                        MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT WeaponName, ManufacturerNo, MadeIn, Year, Description, CategoryID FROM Weapons WHERE WeaponID = @WeaponID";
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            selectCommand.Parameters.AddWithValue("@WeaponID", weaponID);

                            SqlDataReader reader = selectCommand.ExecuteReader();

                            string currentWeaponName = string.Empty;
                            string currentManufacturerNo = string.Empty;
                            string currentMadeIn = string.Empty;
                            DateTime currentYear = DateTime.Now;
                            string currentDescription = string.Empty;
                            string currentCategoryID = string.Empty;

                            if (reader.Read())
                            {
                                currentWeaponName = reader["WeaponName"].ToString();
                                currentManufacturerNo = reader["ManufacturerNo"].ToString();
                                currentMadeIn = reader["MadeIn"].ToString();
                                currentYear = Convert.ToDateTime(reader["Year"]);
                                currentDescription = reader["Description"].ToString();
                                currentCategoryID = reader["CategoryID"].ToString();
                            }

                            reader.Close();

                            // Wax is badal miyaa dhacay ayey hubineysaa
                            bool changesMade = weaponName != currentWeaponName || manufacturerNo != currentManufacturerNo ||
                                               madeIn != currentMadeIn || year != currentYear ||
                                               description != currentDescription || categoryID != currentCategoryID;

                            if (!changesMade)
                            {
                                MessageBox.Show("No Changes Were Made. Please Make Any Update to Save Data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
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
                                    txtBoxManufacturerNo.Clear();
                                    dateTimePicker1.Value = DateTime.Now;
                                    txtBoxDesc.Clear();
                                    comboBoxCategoryIDFK.SelectedIndex = -1;

                                    // Reload data after update
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("There was a problem while updating the Weapon information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
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
                                    txtBoxManufacturerNo.Clear();
                                    dateTimePicker1.Value = DateTime.Now;
                                    txtBoxDesc.Clear();
                                    comboBoxCategoryIDFK.SelectedIndex = -1;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtBoxWeaponID.Text = selectedRow.Cells["WeaponID"].Value.ToString();
                txtBoxWeaponName.Text = selectedRow.Cells["WeaponName"].Value.ToString();
                txtBoxMadeIn.Text = selectedRow.Cells["MadeIn"].Value.ToString();
                txtBoxManufacturerNo.Text = selectedRow.Cells["ManufacturerNo"].Value.ToString();

                // Xaqiijinta iyo beddelka qiimaha Cellka "Year" una beddel DateTime

                if (DateTime.TryParse(selectedRow.Cells["Year"].Value.ToString(), out DateTime yearValue))
                {
                    dateTimePicker1.Value = yearValue;
                }
                else
                {
                    MessageBox.Show("Invalid date format in the 'Year' cell.");
                }

                txtBoxDesc.Text = selectedRow.Cells["Description"].Value.ToString();
                comboBoxCategoryIDFK.Text = selectedRow.Cells["CategoryID"].Value.ToString();
            }
        }

        private void Weapons_Load(object sender, EventArgs e)
        {
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
                        comboBoxCategoryIDFK.Items.Add(rd.GetInt32(0));
                    }
                }
            }
            // Load data into the DataGridView when the form loads
            LoadData();
        }
    }
}
