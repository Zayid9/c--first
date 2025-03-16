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
    public partial class Owners : UserControl
    {
        public Owners()
        {
            InitializeComponent();
        }

        private void btnOwnerInfo_Click(object sender, EventArgs e)
        {
            OwnerInfo ownerInfo = new OwnerInfo();
            ownerInfo.Show();
            this.Hide();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            Locations locations = new Locations();
            locations.Show();
            this.Hide();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            State state = new State();
            state.Show();
            this.Hide();
        }
    }
}
