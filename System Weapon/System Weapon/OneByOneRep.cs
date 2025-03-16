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
using Microsoft.Reporting.WebForms;

namespace System_Weapon
{
    public partial class OneByOneRep : Form
    {
        public OneByOneRep()
        {
            InitializeComponent();
        }

        private void OneByOneRep_Load(object sender, EventArgs e)
        {
            Report_One_By_One OneByOne = new Report_One_By_One();

            string conn = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS;Initial Catalog=WEAPONDB;Integrated Security=True";

            string query = "SELECT * FROM Owners";

            using (SqlConnection conn2 = new SqlConnection(conn))
            {
                SqlDataAdapter adpt = new SqlDataAdapter(query, conn2);

                adpt.Fill(OneByOne, OneByOne.Tables[0].TableName);

                //ReportDataSource ds = new ReportDataSource("One By One Report", OneByOne.Tables[0]);

                //this.reportviewer1.LocalReport.DataSources.Clear();
                //this.reportviewer1.LocalReport.DataSources.Add(ds);

                //this.reportviewer1.RefreshReport();
            }
        }
    }
}
