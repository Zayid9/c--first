using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace System_Weapon
{
    public partial class IndividualReport : Form
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        // Add a variable to store the selected display option
        private string selectedDisplayOption = "OwnerID";


        public IndividualReport()
        {
            InitializeComponent();
            LoadData();
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

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Log Out of the System?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                MainForm Indi = new MainForm();
                Indi.Show();
                this.Hide();
            }
        }

        private void comboBoxIDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDisplayOption = comboBoxIDName.SelectedItem.ToString();

            DataGridViewRowCollection rows = dataGridView1.Rows;

            List<string> displayItems = new List<string>();

            for (int i = 0; i < rows.Count; i++)
            {
                if (selectedDisplayOption == "Name")
                {
                    string name = rows[i].Cells[1].Value.ToString();
                    displayItems.Add(name);
                }
                else
                {
                    string ownerID = rows[i].Cells[0].Value.ToString();
                    displayItems.Add(ownerID);
                }
            }

            // Clear and add items to comboBoxDisplays based on the contents of displayItems
            comboBoxDisplays.Items.Clear();
            comboBoxDisplays.Items.AddRange(displayItems.ToArray());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = comboBoxDisplays.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(searchText))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Determine the data type of the search text
                        bool isNumeric = int.TryParse(searchText, out _);

                        // Construct the SQL query based on data type
                        string query = isNumeric
                            ? "SELECT OwnerName, Natinality, Sex, Telephone, District, Village, City, StateName, CategoryName, WeaponName, ManufacturerNo, MadeIn, Year, ComID, WeaponPrice, ComPrice, TakeOver, Date_TakeOver FROM Owners JOIN Locations ON Owners.OwnerID = Locations.OwnerID JOIN States ON Locations.LocationID = States.LocationID JOIN Categories ON Owners.OwnerID = Categories.OwnerID JOIN Weapons ON Categories.CategoryID = Weapons.CategoryID JOIN Compenisation ON Owners.OwnerID = Compenisation.OwnerID WHERE Owners.OwnerID = @SearchText"
                            : "SELECT OwnerName, Natinality, Sex, Telephone, District, Village, City, StateName, CategoryName, WeaponName, ManufacturerNo, MadeIn, Year, ComID, WeaponPrice, ComPrice, TakeOver, Date_TakeOver FROM Owners JOIN Locations ON Owners.OwnerID = Locations.OwnerID JOIN States ON Locations.LocationID = States.LocationID JOIN Categories ON Owners.OwnerID = Categories.OwnerID JOIN Weapons ON Categories.CategoryID = Weapons.CategoryID JOIN Compenisation ON Owners.OwnerID = Compenisation.OwnerID WHERE Owners.OwnerName LIKE @SearchText";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SearchText", isNumeric ? int.Parse(searchText) : $"%{searchText}%");

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataSet dataSet = new DataSet();
                                adapter.Fill(dataSet, "Owners");

                                // Display the search result in the DataGridView
                                dataGridView1.DataSource = dataSet.Tables["Owners"];
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an ID or name to search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
