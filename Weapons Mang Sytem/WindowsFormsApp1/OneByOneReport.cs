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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class OneByOneReport : Form
    {
        private DataTable filteredData;

        public OneByOneReport(DataTable filteredData)
        {
            InitializeComponent();
            this.filteredData = filteredData;
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

        private void OneByOneReport_Load(object sender, EventArgs e)
        {
            

            OneByOne OneReport = new OneByOne();
            string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS;Initial Catalog=WEAPONDB;Integrated Security=True";

            string query = "SELECT Owners.OwnerName, Owners.Natinality, Owners.Sex, Owners.Telephone, Locations.District, Locations.Village, Locations.City, States.StateName, Categories.CategoryName, Weapons.WeaponName, Weapons.ManufacturerNo, \r\n                  Weapons.MadeIn, Weapons.Year, Compenisation.OwnerID, Compenisation.WeaponPrice, Compenisation.ComPrice, Compenisation.TakeOver, Compenisation.Date_TakeOver\r\nFROM     Owners INNER JOIN\r\n                  Locations ON Owners.OwnerID = Locations.OwnerID INNER JOIN\r\n                  States ON Locations.LocationID = States.LocationID INNER JOIN\r\n                  Categories ON Owners.OwnerID = Categories.OwnerID INNER JOIN\r\n                  Weapons ON Categories.CategoryID = Weapons.CategoryID INNER JOIN\r\n                  Compenisation ON Owners.OwnerID = Compenisation.OwnerID";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            adpt.Fill(OneReport, OneReport.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("OneByOneReports", filteredData);
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }
    }
}
