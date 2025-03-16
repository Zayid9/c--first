using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            IndividualReport report = new IndividualReport();
            report.Show();
            this.Hide();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            AllReport allReport = new AllReport();
            allReport.Show(); 
            this.Hide();
        }
    }
}
