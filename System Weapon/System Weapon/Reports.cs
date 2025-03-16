using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace System_Weapon
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IndividualReport individualReport = new IndividualReport();
            individualReport.Show();
            this.Hide();
        }
    }
}
