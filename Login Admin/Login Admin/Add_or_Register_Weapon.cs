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

namespace Login_Admin
{
    public partial class Add_or_Register_Weapon : Form
    {
        private string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False;Initial Catalog=ADMIN_LOGIN;";

        private List<Add_or_Register_Weapon> weapons = new List<Add_or_Register_Weapon>();
        private Add_or_Register_Weapon currentWeapon;

        public Add_or_Register_Weapon()
        {
            InitializeComponent();
            currentWeapon = new Add_or_Register_Weapon();
            txtBoxWeaponID.Text = GenerateID().ToString(); // Set the generated ID in the TextBox
        }

        private int GenerateID()
        {
            int generatedID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT MAX(WeaponID) FROM Add_Or_Registration", connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            generatedID = Convert.ToInt32(result) + 1;
                        }
                        else
                        {
                            generatedID = 0001;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during ID generation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return generatedID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if ID already exists
                    using (SqlCommand checkCommand = new SqlCommand("SELECT * FROM Add_Or_Registration WHERE WeaponID=@WeaponID", connection))
                    {
                        checkCommand.Parameters.AddWithValue("@WeaponID", int.Parse(txtBoxWeaponID.Text));
                        using (SqlDataReader reader = checkCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Check for empty text boxes
                    if (string.IsNullOrWhiteSpace(txtBoxWeaponName.Text) || string.IsNullOrWhiteSpace(txtBoxWeaponID.Text) || string.IsNullOrWhiteSpace(txtBoxWeaponSerialNo.Text) ||
                        string.IsNullOrWhiteSpace(txtBoxOwnersName.Text) || string.IsNullOrWhiteSpace(txtBoxManufacturerName.Text) || string.IsNullOrWhiteSpace(txtBoxShooting.Text) || string.IsNullOrWhiteSpace(txtBoxPrice.Text))
                    {
                        MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert data into the Add_Or_Registration table
                    using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Add_Or_Registration (WeaponName, WeaponID, SerialNumber, OwnerName, Manufacturer, Shooting, Price) VALUES (@WeaponName, @WeaponID, @SerialNumber, @OwnerName, @Manufacturer, @Shooting, @Price)", connection))
                    {
                        insertCommand.Parameters.AddWithValue("@WeaponName", txtBoxWeaponName.Text);
                        insertCommand.Parameters.AddWithValue("@WeaponID", int.Parse(txtBoxWeaponID.Text));
                        insertCommand.Parameters.AddWithValue("@SerialNumber", txtBoxWeaponSerialNo.Text);
                        insertCommand.Parameters.AddWithValue("@OwnerName", txtBoxOwnersName.Text);
                        insertCommand.Parameters.AddWithValue("@Manufacturer", txtBoxManufacturerName.Text);
                        insertCommand.Parameters.AddWithValue("@Shooting", txtBoxShooting.Text);
                        insertCommand.Parameters.AddWithValue("@Price", decimal.Parse(txtBoxPrice.Text));

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Successfully saved into database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Set the generated ID in the TextBox after inserting into the database
                txtBoxWeaponID.Text = GenerateID().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error due to: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxWeaponName.Clear();
            txtBoxWeaponID.Text = GenerateID().ToString(); // Set the generated ID in the TextBox after clearing
            txtBoxWeaponSerialNo.Clear();
            txtBoxOwnersName.Clear();
            txtBoxManufacturerName.Clear();
            txtBoxShooting.Clear();
            txtBoxPrice.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
