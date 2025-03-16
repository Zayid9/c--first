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
    public partial class Category : Form
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public Category()
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
                string query = "SELECT * FROM Categories";

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

                    string query = "SELECT * FROM Categories";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();

                            adapter.Fill(dataSet, "Categories");

                            dataGridView1.DataSource = dataSet.Tables["Categories"];
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
                // Get values from input fields
                string CategoryID = txtBoxCategoryID.Text; 
                string CategoryName = txtBoxCategoryName.Text;
                string OwnerID = comboBoxIDName.SelectedItem?.ToString(); 
                string Description = txtBoxDesc.Text;

                // Hubinta 
                if (string.IsNullOrWhiteSpace(CategoryName) || string.IsNullOrWhiteSpace(OwnerID))
                {
                    MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if OwnerID already exists in Categories
                    string checkQuery = $"SELECT COUNT(*) FROM Categories WHERE OwnerID = {OwnerID}";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            MessageBox.Show("OwnerID is already assigned to another category. Please select a different owner or update the existing category.", "Duplicate OwnerID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new record
                    string insertQuery = "INSERT INTO Categories (CategoryName, OwnerID, Description) VALUES (@CategoryName, @OwnerID, @Description)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@CategoryName", CategoryName);
                        insertCommand.Parameters.AddWithValue("@OwnerID", OwnerID);
                        insertCommand.Parameters.AddWithValue("@Description", Description);

                        int result = insertCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Category is successfully saved");

                            // Clear text boxes and reset combo box
                            txtBoxCategoryID.Clear();
                            txtBoxCategoryName.Clear();
                            comboBoxIDName.Text = "";
                            txtBoxDesc.Clear();

                            LoadData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while saving the Category information");
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes and reset combo box
            txtBoxCategoryID.Clear();
            txtBoxCategoryName.Clear();
            comboBoxIDName.Text = "";
            txtBoxDesc.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string CategoryID = txtBoxCategoryID.Text;
                string CategoryName = txtBoxCategoryName.Text;
                string OwnerID = comboBoxIDName.SelectedItem?.ToString();
                string Description = txtBoxDesc.Text;

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(CategoryID) || string.IsNullOrWhiteSpace(CategoryName) || string.IsNullOrWhiteSpace(OwnerID))
                {
                    MessageBox.Show("Please select a category from the grid and fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if OwnerID already exists in Categories for other records
                    string checkQuery = $"SELECT COUNT(*) FROM Categories WHERE OwnerID = {OwnerID} AND CategoryID != {CategoryID}";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            MessageBox.Show("OwnerID is already assigned to another category. Please select a different owner or update the existing category.", "Duplicate OwnerID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Retrieve the current record's information
                    string selectQuery = "SELECT CategoryName, OwnerID, Description FROM Categories WHERE CategoryID = @CategoryID";

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@CategoryID", CategoryID);

                        SqlDataReader reader = selectCommand.ExecuteReader();

                        string currentCategoryName = string.Empty;
                        string currentOwnerID = string.Empty;
                        string currentDescription = string.Empty;

                        if (reader.Read())
                        {
                            currentCategoryName = reader["CategoryName"].ToString();
                            currentOwnerID = reader["OwnerID"].ToString();
                            currentDescription = reader["Description"].ToString();
                        }

                        reader.Close();

                        // Check if any changes were made
                        bool changesMade = CategoryName != currentCategoryName || OwnerID != currentOwnerID || Description != currentDescription;

                        if (!changesMade)
                        {
                            MessageBox.Show("No Changes Were Made. Please Make Any Update to Save Data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Update existing record
                        string updateQuery = "UPDATE Categories SET CategoryName = @CategoryName, OwnerID = @OwnerID, Description = @Description WHERE CategoryID = @CategoryID";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
                            updateCommand.Parameters.AddWithValue("@CategoryName", CategoryName);
                            updateCommand.Parameters.AddWithValue("@OwnerID", OwnerID);
                            updateCommand.Parameters.AddWithValue("@Description", Description);

                            int result = updateCommand.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Category is successfully updated");

                                // Clear text boxes and reset combo box
                                txtBoxCategoryID.Clear();
                                txtBoxCategoryName.Clear();
                                comboBoxIDName.Text = "";
                                txtBoxDesc.Clear();

                                LoadData(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while updating the Category information");
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedCategoryID = txtBoxCategoryID.Text;

            if (string.IsNullOrEmpty(selectedCategoryID))
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            try
            {


                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Delete the selected record
                        string deleteQuery = "DELETE FROM Categories WHERE CategoryID = @CategoryID";

                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@CategoryID", selectedCategoryID);

                            int deleteResult = deleteCommand.ExecuteNonQuery();

                            if (deleteResult > 0)
                            {
                                MessageBox.Show("Category is successfully deleted");

                                // Clear text boxes and reset combo box
                                txtBoxCategoryID.Clear();
                                txtBoxCategoryName.Clear();
                                comboBoxIDName.Text = "";
                                txtBoxDesc.Clear();

                                LoadData(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while deleting the Category");
                            }
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtBoxCategoryID.Text = selectedRow.Cells["CategoryID"].Value.ToString();
                txtBoxCategoryName.Text = selectedRow.Cells["CategoryName"].Value.ToString();
                comboBoxIDName.Text = selectedRow.Cells["OwnerID"].Value.ToString();
                txtBoxDesc.Text = selectedRow.Cells["Description"].Value.ToString();
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
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
                        comboBoxIDName.Items.Add(rd.GetInt32(0));
                    }
                }
            }

            // Load data into the DataGridView when the form loads
            LoadData();
        }
    }
}
