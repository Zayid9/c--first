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
    public partial class IndividualReport : Form
    {
        // First Connection
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        // Waa variable keedinaaya selected display option
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

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Owners");

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Log Out of the System?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                MainForm Indi = new MainForm();
                this.Hide();
                Indi.Show();
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

            // Wxey tireysaa kuna dareysaa comboboxDisplays-ka Aydoo isticmaaleysa Waxaad dooratay
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

                        // Data Type waxaad raadineyso 
                        bool isNumeric = int.TryParse(searchText, out _);

                        // SQL Query-ga ayaan ku dhisay meshaan
                        string query = isNumeric
                            ? "SELECT OwnerName, Natinality, Sex, Telephone, District, Village, City, StateName, CategoryName, WeaponName, ManufacturerNo, MadeIn, Year, ComID, WeaponPrice, ComPrice, TakeOver, Date_TakeOver FROM Owners JOIN Locations ON Owners.OwnerID = Locations.OwnerID JOIN States ON Locations.LocationID = States.LocationID JOIN Categories ON Owners.OwnerID = Categories.OwnerID JOIN Weapons ON Categories.CategoryID = Weapons.CategoryID JOIN Compenisation ON Owners.OwnerID = Compenisation.OwnerID WHERE Owners.OwnerID = @SearchText"
                            : "SELECT OwnerName, Natinality, Sex, Telephone, District, Village, City, StateName, CategoryName, WeaponName, ManufacturerNo, MadeIn, Year, ComID, WeaponPrice, ComPrice, TakeOver, Date_TakeOver FROM Owners JOIN Locations ON Owners.OwnerID = Locations.OwnerID JOIN States ON Locations.LocationID = States.LocationID JOIN Categories ON Owners.OwnerID = Categories.OwnerID JOIN Weapons ON Categories.CategoryID = Weapons.CategoryID JOIN Compenisation ON Owners.OwnerID = Compenisation.OwnerID WHERE Owners.OwnerName LIKE @SearchText";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SearchText", isNumeric ? (object)int.Parse(searchText) : (object)$"%{searchText}%");

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
            comboBoxIDName.Text = "";
            comboBoxDisplays.Text = "";
        }

        // Waa Functionka Qabanaya in datagridview-ga lagala baxo data ee uu raadiyay Userka kuna raadiyay ID ama Name Kdibna Print ayaa dhacaya
        private DataTable GetFilteredData()
        {
            DataTable filteredData = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                filteredData.Columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow addedRow = filteredData.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        addedRow[cell.ColumnIndex] = cell.Value;
                    }
                }
            }

            return filteredData;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable filteredData = GetFilteredData();

            OneByOneReport reportOneByOne = new OneByOneReport(filteredData);
            reportOneByOne.Show();
            this.Hide();
        }
    }
}
