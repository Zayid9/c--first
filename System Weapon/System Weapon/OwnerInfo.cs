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
    public partial class OwnerInfo : Form
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public OwnerInfo()
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
                string query = "SELECT * FROM Owners";

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
                    string query = "SELECT * FROM Owners";

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataAdapter to fetch the data into a DataSet
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Owners");

                            // Bind the DataSet to the DataGridView
                            dataGridView1.DataSource = dataSet.Tables["Owners"];
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
            string OwnerID = txtBoxOwnerID.Text;
            string OwnerName = txtBoxOwnerName.Text;
            string Nationality = txtBoxNationality.Text;
            string? Sex = comboBoxSex.SelectedItem?.ToString();
            string Tell = txtBoxTell.Text;

            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(OwnerName) || string.IsNullOrWhiteSpace(Nationality) || string.IsNullOrWhiteSpace(Sex) || string.IsNullOrWhiteSpace(Tell))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // query
                string query = "INSERT INTO Owners (OwnerName, Natinality, Sex, Telephone) VALUES ('" + OwnerName + "', '" + Nationality + "', '" + Sex + "' ,'" + Tell + "')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteNonQuery();

                    if (result != 0)
                    {
                        MessageBox.Show("Owner is successfully saved");

                        // Clear text boxes and reset combo box
                        txtBoxOwnerID.Clear();
                        txtBoxOwnerName.Clear();
                        txtBoxNationality.Clear();
                        comboBoxSex.SelectedIndex = -1;
                        txtBoxTell.Clear();

                        ReadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("There was a problem while saving the owner info");
                    }
                }

                connection.Close();
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string OwnerID = txtBoxOwnerID.Text;
            string OwnerName = txtBoxOwnerName.Text;
            string Nationality = txtBoxNationality.Text;
            string? Sex = comboBoxSex.SelectedItem?.ToString();
            string Tell = txtBoxTell.Text;

            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(OwnerID) || string.IsNullOrWhiteSpace(OwnerName) || string.IsNullOrWhiteSpace(Nationality) || string.IsNullOrWhiteSpace(Sex) || string.IsNullOrWhiteSpace(Tell))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // query
                string query = "UPDATE Owners SET OwnerName = @OwnerName, Natinality = @Nationality, Sex = @Sex, Telephone = @Tell WHERE OwnerID = @OwnerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OwnerID", OwnerID);
                    command.Parameters.AddWithValue("@OwnerName", OwnerName);
                    command.Parameters.AddWithValue("@Nationality", Nationality);
                    command.Parameters.AddWithValue("@Sex", Sex);
                    command.Parameters.AddWithValue("@Tell", Tell);

                    var result = command.ExecuteNonQuery();

                    if (result != 0)
                    {
                        MessageBox.Show("Owner is successfully updated");

                        // Clear text boxes and reset combo box
                        txtBoxOwnerID.Clear();
                        txtBoxOwnerName.Clear();
                        txtBoxNationality.Clear();
                        comboBoxSex.SelectedIndex = -1;
                        txtBoxTell.Clear();

                        ReadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("There was a problem while updating the owner info");
                    }
                }

                connection.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string OwnerID = txtBoxOwnerID.Text;

            // Check if OwnerID is empty
            if (string.IsNullOrWhiteSpace(OwnerID))
            {
                MessageBox.Show("Please select a row to delete", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this owner?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // query
                    string query = "DELETE FROM Owners WHERE OwnerID = @OwnerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerID", OwnerID);

                        var deleteResult = command.ExecuteNonQuery();

                        if (deleteResult != 0)
                        {
                            MessageBox.Show("Owner is successfully deleted");

                            // Clear text boxes and reset combo box
                            txtBoxOwnerID.Clear();
                            txtBoxOwnerName.Clear();
                            txtBoxNationality.Clear();
                            comboBoxSex.SelectedIndex = -1;
                            txtBoxTell.Clear();

                            ReadStudentData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while deleting the owner info");
                        }
                    }

                    connection.Close();
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes and reset combo box
            txtBoxOwnerID.Clear();
            txtBoxOwnerName.Clear();
            txtBoxNationality.Clear();
            comboBoxSex.SelectedIndex = -1;
            txtBoxTell.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate text boxes with selected row data
                txtBoxOwnerID.Text = selectedRow.Cells["OwnerID"].Value.ToString(); 
                txtBoxOwnerName.Text = selectedRow.Cells["OwnerName"].Value.ToString();
                txtBoxNationality.Text = selectedRow.Cells["Natinality"].Value.ToString(); 
                comboBoxSex.SelectedItem = selectedRow.Cells["Sex"].Value.ToString(); 
                txtBoxTell.Text = selectedRow.Cells["Telephone"].Value.ToString(); 
            }
        }


        private void OwnerInfo_Load(object sender, EventArgs e)
        {
            // Set the selection mode to FullRowSelect
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Load data into the DataGridView when the form loads
            LoadData();
        }

    }
}
