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
    public partial class State : Form
    {
        // Connectionka bilawgiisa kowaad
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public State()
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM States";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();

                            adapter.Fill(dataSet, "States");

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
            string StateID = txtBoxStateID.Text;
            string StateName = txtBoxStateName.Text;
            string LocationID = comboBoxLocationID.SelectedItem?.ToString();

            // Xaqiijinta txtbox iyo combobox
            if (string.IsNullOrWhiteSpace(StateName) || string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Hubinta inuu IDga loca u assign garesan yhy mdkle io inkle
                string checkQuery = $"SELECT COUNT(*) FROM States WHERE LocationID = {LocationID}";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("LocationID is already assigned to another location. Please select a different owner or update the existing location.", "Duplicate OwnerID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Ku uruurinta ama ku shubista data
                        string query = "INSERT INTO States (StateName, LocationID) VALUES (@StateName, @LocationID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StateName", StateName);
                            command.Parameters.AddWithValue("@LocationID", LocationID);

                            var result = command.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("State is successfully saved");

                                // Clear text boxes and reset combo box
                                txtBoxStateID.Clear();
                                txtBoxStateName.Clear();
                                comboBoxLocationID.Text = "";

                                ReadData();
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
            // wxey tireysaa text boxes iyo combo box
            txtBoxStateID.Clear();
            txtBoxStateName.Clear();
            comboBoxLocationID.Text = "";  // Waa qaab loo tiro combobox yada
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string StateID = txtBoxStateID.Text;
            string StateName = txtBoxStateName.Text;
            string LocationID = comboBoxLocationID.SelectedItem?.ToString();

            // Waa vairibale noo ogalnaya si aan ula socono in isbedel la sameeyay
            bool changesMade = false;

            // Hubinta
            if (string.IsNullOrWhiteSpace(StateID) || string.IsNullOrWhiteSpace(StateName) || string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Hubinta ID ga
                string checkQuery = "SELECT COUNT(*) FROM States WHERE LocationID = @LocationID AND StateID != @StateID";
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
                        // Queryga cadeynaya si aad u soo ceshato macluumaadka State hadda

                        string currentStateQuery = "SELECT StateName, LocationID FROM States WHERE StateID = @StateID";
                        using (SqlCommand currentStateCommand = new SqlCommand(currentStateQuery, connection))
                        {
                            currentStateCommand.Parameters.AddWithValue("@StateID", StateID);

                            SqlDataReader reader = currentStateCommand.ExecuteReader();

                            if (reader.Read())
                            {
                                string currentStateName = reader["StateName"].ToString();
                                string currentLocationID = reader["LocationID"].ToString();

                                // Hubi is badal miyaa jira
                                if (currentStateName != StateName || currentLocationID != LocationID)
                                {
                                    changesMade = true; // Si aad is badalka ula socto True ka dhiga
                                }
                            }

                            reader.Close();
                        }

                        //  Haduu is badal samyy Userka Update ka cusub samee
                        if (changesMade)
                        {
                            // Query to update data in States
                            string updateQuery = "UPDATE States SET StateName = @StateName, LocationID = @LocationID WHERE StateID = @StateID";

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@StateName", StateName);
                                command.Parameters.AddWithValue("@LocationID", LocationID);
                                command.Parameters.AddWithValue("@StateID", StateID);

                                var result = command.ExecuteNonQuery();

                                if (result != 0)
                                {
                                    MessageBox.Show("State is successfully updated", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Clear text boxes and combo box
                                    txtBoxStateID.Clear();
                                    txtBoxStateName.Clear();
                                    comboBoxLocationID.SelectedIndex = -1;
                                }
                                else
                                {
                                    MessageBox.Show("There was a problem while updating the State info", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Changes Were Made. Please Make Any Update to Save Data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Hubinta
            if (string.IsNullOrWhiteSpace(StateID) || string.IsNullOrWhiteSpace(StateName) || string.IsNullOrWhiteSpace(LocationID))
            {
                MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this state?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;  // Hduu Cancel dhho Userka
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to delete data from States
                string query = "DELETE FROM States WHERE StateID = @StateID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StateID", StateID);

                    var deleteResult = command.ExecuteNonQuery();

                    if (deleteResult != 0)
                    {
                        MessageBox.Show("State is Successfully Deleted");

                        txtBoxStateID.Clear();
                        txtBoxStateName.Clear();
                        comboBoxLocationID.Text = "";  

                        ReadData();
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

                txtBoxStateID.Text = selectedRow.Cells["StateID"].Value.ToString();
                txtBoxStateName.Text = selectedRow.Cells["StateName"].Value.ToString();
                comboBoxLocationID.Text = selectedRow.Cells["LocationID"].Value.ToString();

            }
        }

        private void State_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // combobox Data View

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT LocationID FROM Locations";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandText = query;
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        rd.GetInt32(0);
                        comboBoxLocationID.Items.Add(rd.GetInt32(0));
                    }
                }
            }
            // Load data into the DataGridView when the form loads
            LoadData();
        }
    }
}