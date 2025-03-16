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
    public partial class Locations : Form
    {
        // Connectionka Kowaad ee databaseka wayy
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public Locations()
        {
            InitializeComponent();
        }

        // Function kaan wxuu noosoo aqrinayaa Table ka 
        private void ReadData()
        {
            // Bilaabista Connectionka
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select data from the Owners table
                    string query = "SELECT * FROM Locations";

                    // Waxaa halkaan laga sameynyaa SqlCommand si looga shaqeysio query aad soo qortay
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Waxa halkan ka sameysan SqlDataAdapter si loo helo data-da ku jira table-ka ama Dataset-ka
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // DataSet Cusub ayaa ka sameysmay halkaan
                            DataSet dataSet = new DataSet();

                            // waxaa halakan lagu buuxiyay dataSetka table nameka 
                            adapter.Fill(dataSet, "Locations");

                            // Waxaan Ku dhajiyay data-da iney kasoo muuqato dataGridView-ga
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string LocationID = txtBoxLoactionID.Text;
            string District = txtBoxDistrict.Text;
            string Village = txtBoxVillege.Text;
            string City = txtBoxCity.Text;
            string Description = txtBoxDiscriptions.Text;
            string OwnerID = comboBoxIDName.SelectedItem?.ToString(); 

            // Xaqiijinta in txtBox maran yihiin io inkle
            if (string.IsNullOrWhiteSpace(District) || string.IsNullOrWhiteSpace(Village) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Description) || string.IsNullOrWhiteSpace(OwnerID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query xaqiijinaya in OwnerID loo assign gareyy midkle ama iyo inkle
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
                        // Data ayaa lagu aruurinayaa ama galinayaa
                        string query = "INSERT INTO Locations (District, Village, City, Descriptions, OwnerID) VALUES (@District, @Village, @City, @Description, @OwnerID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // parameters ahaan ugu shub mid kasta oo ka tirsan SQL injection
                            command.Parameters.AddWithValue("@District", District);
                            command.Parameters.AddWithValue("@Village", Village);
                            command.Parameters.AddWithValue("@City", City);
                            command.Parameters.AddWithValue("@Description", Description);
                            command.Parameters.AddWithValue("@OwnerID", OwnerID);

                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("Location is successfully saved");

                                txtBoxLoactionID.Clear();
                                txtBoxDistrict.Clear();
                                txtBoxVillege.Clear();
                                txtBoxCity.Clear();
                                txtBoxDiscriptions.Clear();
                                comboBoxIDName.Text = "";

                                ReadData();
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
            // Tirista txtBox yada 
            txtBoxLoactionID.Clear();
            txtBoxDistrict.Clear();
            txtBoxVillege.Clear();
            txtBoxCity.Clear();
            txtBoxDiscriptions.Clear();
            comboBoxIDName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string LocationID = txtBoxLoactionID.Text;
            string District = txtBoxDistrict.Text;
            string Village = txtBoxVillege.Text;
            string City = txtBoxCity.Text;
            string Description = txtBoxDiscriptions.Text;
            int SelectedOwnerID = Convert.ToInt32(comboBoxIDName.SelectedItem);

            // Xaqiijinta txtBox iney maran yhn
            if (string.IsNullOrWhiteSpace(LocationID) || string.IsNullOrWhiteSpace(District) || string.IsNullOrWhiteSpace(Village) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Description) || comboBoxIDName.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Xaqiijinta hdii OwnerID-ga Mar hore loo assigned  Midkle iyo inkle
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
                        // Keydinta ama heynta valueskii hore ku jiray data-da
                        string originalDistrict, originalVillage, originalCity, originalDescription;
                        using (SqlCommand selectCommand = new SqlCommand("SELECT District, Village, City, Descriptions FROM Locations WHERE LocationID = @LocationID", connection))
                        {
                            selectCommand.Parameters.AddWithValue("@LocationID", LocationID);
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    originalDistrict = reader["District"].ToString();
                                    originalVillage = reader["Village"].ToString();
                                    originalCity = reader["City"].ToString();
                                    originalDescription = reader["Descriptions"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Location not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Update location-ka
                        string query = "UPDATE Locations SET District = @District, Village = @Village, City = @City, Descriptions = @Description, OwnerID = @OwnerID WHERE LocationID = @LocationID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@LocationID", LocationID);
                            command.Parameters.AddWithValue("@District", District);
                            command.Parameters.AddWithValue("@Village", Village);
                            command.Parameters.AddWithValue("@City", City);
                            command.Parameters.AddWithValue("@Description", Description);
                            command.Parameters.AddWithValue("@OwnerID", SelectedOwnerID);

                            var result = command.ExecuteNonQuery();

                            //  In wax is badal uu sameyy userka io inkle
                            if (result != 0)
                            {
                                // Hubi wax maka badaly mse
                                if (originalDistrict != District || originalVillage != Village || originalCity != City || originalDescription != Description)
                                {
                                    MessageBox.Show("Location is successfully updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                    txtBoxLoactionID.Clear();
                                    txtBoxDistrict.Clear();
                                    txtBoxVillege.Clear();
                                    txtBoxCity.Clear();
                                    txtBoxDiscriptions.Clear();
                                    comboBoxIDName.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("No Changes Were Made. Please Make Any Update to Save Data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No changes were made. Please make any update to save data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string LocationID = txtBoxLoactionID.Text;

            // Xaqiijin
            if (string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please select a location to delete", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
                        // Delete gareynta ayaa bilaabnysa
                        string query = "DELETE FROM Locations WHERE LocationID = @LocationID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@LocationID", LocationID);

                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("Location is successfully deleted");

                                // Success ka danbe text boxes iyo  combo box ayaa laga tiryaa data-da
                                txtBoxLoactionID.Clear();
                                txtBoxDistrict.Clear();
                                txtBoxVillege.Clear();
                                txtBoxCity.Clear();
                                txtBoxDiscriptions.Clear();
                                comboBoxIDName.Text = "";

                                ReadData();
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

                txtBoxLoactionID.Text = selectedRow.Cells["LocationID"].Value.ToString();
                txtBoxDistrict.Text = selectedRow.Cells["District"].Value.ToString();
                txtBoxVillege.Text = selectedRow.Cells["Village"].Value.ToString();
                txtBoxCity.Text = selectedRow.Cells["City"].Value.ToString();
                txtBoxDiscriptions.Text = selectedRow.Cells["Descriptions"].Value.ToString();
                comboBoxIDName.Text = selectedRow.Cells["OwnerID"].Value.ToString();
            }
        }

        private void Locations_Load(object sender, EventArgs e)
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
            // Load data ayadaa ku shubeysa datgridviewga
            LoadData();
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
    }
}