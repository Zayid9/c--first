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
    public partial class RegisterWeapon : UserControl
    {
        public RegisterWeapon()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnOwnerInfo_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            Weapons weapons = new Weapons();
            weapons.Show();
            this.Hide();
        }
    }
}
