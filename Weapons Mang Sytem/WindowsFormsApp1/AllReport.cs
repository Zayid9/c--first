using Microsoft.Reporting.WinForms;
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
    public partial class AllReport : Form
    {
        public AllReport()
        {
            InitializeComponent();
        }

        private void AllReport_Load(object sender, EventArgs e)
        {
            AllDataReport allDataReport = new AllDataReport();
            
            string ConnectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS;Initial Catalog=WEAPONDB;Integrated Security=True";
            
            string query = "SELECT Owners.OwnerID, Owners.OwnerName, Owners.Natinality, Owners.Sex, Owners.Telephone, Locations.LocationID, Locations.District, Locations.Village, Locations.City, Locations.OwnerID AS Expr1, States.StateID, States.StateName," +
                "States.LocationID AS Expr2, Categories.CategoryID, Categories.CategoryName, Categories.OwnerID AS Expr3, Weapons.WeaponID, Weapons.WeaponName, Weapons.ManufacturerNo, Weapons.MadeIn, Weapons.Year," +
                "Weapons.CategoryID AS Expr4, Compenisation.ComID, Compenisation.OwnerID AS Expr5, Compenisation.WeaponPrice, Compenisation.ComPrice, Compenisation.TakeOver, Compenisation.Date_TakeOver FROM Owners INNER JOIN " +
                "Locations ON Owners.OwnerID = Locations.OwnerID INNER JOIN States ON Locations.LocationID = States.LocationID INNER JOIN " +
                "Categories ON Owners.OwnerID = Categories.OwnerID INNER JOIN Weapons ON Categories.CategoryID = Weapons.CategoryID INNER JOIN " +
                " Compenisation ON Owners.OwnerID = Compenisation.OwnerID";

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            adpt.Fill(allDataReport, allDataReport.Tables[0].TableName);

            ReportDataSource reportDataSource = new ReportDataSource("AllReport", allDataReport.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
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
    }
}
