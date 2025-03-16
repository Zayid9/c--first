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
using System.Globalization;


namespace WindowsFormsApp1
{
    public partial class OwnerInfo : Form
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public OwnerInfo()
        {
            InitializeComponent();
            Nationality();


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

        private void ReadData()
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Owners";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a new DataSet
                            DataSet dataSet = new DataSet();

                            // Fill the DataSet with data from the database
                            adapter.Fill(dataSet, "Owners");

                            // Ku dhaji DataSet-ka DataGridView
                            dataGridView1.DataSource = dataSet.Tables["Owners"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nationality()
        {
            List<string> countries = new List<string>();

            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo region = new RegionInfo(culture.Name);
                if (!countries.Contains(region.EnglishName))
                {
                    countries.Add(region.EnglishName);
                }
            }

            countries.Sort();

            comboboxNationality.DataSource = countries;
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ownerName = txtBoxOwnerName.Text;
                string nationality = comboboxNationality.Text;
                string sex = comboBoxSex.SelectedItem?.ToString();
                string telephone = txtBoxTell.Text;

                if (string.IsNullOrWhiteSpace(ownerName) || string.IsNullOrWhiteSpace(nationality) ||
                    string.IsNullOrWhiteSpace(telephone) || comboBoxSex.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the country code based on the selected nationality
                RegionInfo region = new RegionInfo(new CultureInfo(nationality, false).LCID);
                string countryCode = "+" + region;

                // Ensure the telephone number starts with the country code
                if (!telephone.StartsWith(countryCode))
                {
                    MessageBox.Show("Telephone number must start with the selected country code", "Invalid Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string saveQuery = @"INSERT INTO Owners (OwnerName, Natinality, Sex, Telephone) 
                                VALUES (@OwnerName, @Nationality, @Sex, @Telephone)";

                    using (SqlCommand saveCommand = new SqlCommand(saveQuery, connection))
                    {
                        saveCommand.Parameters.AddWithValue("@OwnerName", ownerName);
                        saveCommand.Parameters.AddWithValue("@Nationality", nationality);
                        saveCommand.Parameters.AddWithValue("@Sex", sex);
                        saveCommand.Parameters.AddWithValue("@Telephone", telephone);

                        int result = saveCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Owner information saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while saving the owner information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string ownerID = txtBoxOwnerID.Text;
                string ownerName = txtBoxOwnerName.Text;
                string nationality = comboboxNationality.Text;
                string sex = comboBoxSex.SelectedItem?.ToString();
                string telephone = txtBoxTell.Text;

                if (string.IsNullOrWhiteSpace(ownerID) || string.IsNullOrWhiteSpace(ownerName) ||
                    string.IsNullOrWhiteSpace(nationality) || string.IsNullOrWhiteSpace(telephone) || comboBoxSex.SelectedItem == null)
                {
                    MessageBox.Show("Please select a row to update and fill in all the required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the country code based on the selected nationality
                RegionInfo region = new RegionInfo(new CultureInfo(nationality, false).LCID);
                string countryCode = "+" + region;

                // Ensure the telephone number starts with the country code
                if (!telephone.StartsWith(countryCode))
                {
                    MessageBox.Show("Telephone number must start with the selected country code", "Invalid Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @"UPDATE Owners SET OwnerName=@OwnerName, Natinality=@Nationality, Sex=@Sex, Telephone=@Telephone WHERE OwnerID=@OwnerID";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@OwnerID", ownerID);
                        updateCommand.Parameters.AddWithValue("@OwnerName", ownerName);
                        updateCommand.Parameters.AddWithValue("@Nationality", nationality);
                        updateCommand.Parameters.AddWithValue("@Sex", sex);
                        updateCommand.Parameters.AddWithValue("@Telephone", telephone);

                        int result = updateCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Owner information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem while updating the owner information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
                string ownerID = txtBoxOwnerID.Text;

                if (string.IsNullOrWhiteSpace(ownerID))
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

                        string deleteQuery = "DELETE FROM Owners WHERE OwnerID=@OwnerID";

                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@OwnerID", ownerID);

                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Owner information deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("There was a problem while deleting the owner information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtBoxOwnerID.Clear();
            txtBoxOwnerName.Clear();
            comboboxNationality.SelectedIndex = -1;
            comboBoxSex.SelectedIndex = -1;
            txtBoxTell.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtBoxOwnerID.Text = selectedRow.Cells["OwnerID"].Value.ToString();
                txtBoxOwnerName.Text = selectedRow.Cells["OwnerName"].Value.ToString();
                comboboxNationality.Text = selectedRow.Cells["Natinality"].Value.ToString();
                comboBoxSex.SelectedItem = selectedRow.Cells["Sex"].Value.ToString();
                txtBoxTell.Text = selectedRow.Cells["Telephone"].Value.ToString();
            }
        }

        private void OwnerInfo_Load(object sender, EventArgs e)
        {
            // Set the placeholder text for comboBoxSex
            comboBoxSex.Text = "Please Select Your Sex";

            // Set the placeholder text for comboboxNationality
            comboboxNationality.Text = "Please Select Your Country";

            // Waa U dejinta qaabka xulashada DataGridviewga la doortay Row giisa ama Column kiisa

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Ku shubista xogta DataGridView marka foomku soo baxo
            LoadData();
        }



    }
}