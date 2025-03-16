using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class Dashboard : UserControl
    {
        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

        public Dashboard()
        {
            InitializeComponent();
            DisplayWeaponType();
            DisplayMostState();
            DisplayAvaiblePple();
        }

        private void DisplayWeaponType()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT COUNT(CategoryID) FROM Categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempAB = 0;

                        if (reader.Read())
                        {
                            tempAB = Convert.ToInt32(reader[0]);
                            lblWeaponType.Text = tempAB.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayMostState()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT TOP 1 StateName, COUNT(StateID) AS StateCount " +
                                        "FROM States " +
                                        "GROUP BY StateName " +
                                        "ORDER BY StateCount DESC";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string mostStateName = reader["StateName"].ToString();
                            int stateCount = Convert.ToInt32(reader["StateCount"]);
                            lblMostState.Text = $"{mostStateName}";
                        }
                        else
                        {
                            lblMostState.Text = "No data available";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void DisplayAvaiblePple()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT COUNT(OwnerID) FROM Owners";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempAB = 0;

                        if (reader.Read())
                        {
                            tempAB = Convert.ToInt32(reader[0]);
                            lblpple.Text = tempAB.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
