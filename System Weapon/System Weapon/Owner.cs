using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Weapon
{
    public partial class Owner : UserControl
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnOwnerInfo_Click(object sender, EventArgs e)
        {
            OwnerInfo ownerInfo = new OwnerInfo();
            ownerInfo.Show();
            this.Hide();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            Location ownerInfo = new Location();
            ownerInfo.Show();
            this.Hide();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            State ownerinfo = new State();
            ownerinfo.Show();
            this.Hide();
        }
    }
}
