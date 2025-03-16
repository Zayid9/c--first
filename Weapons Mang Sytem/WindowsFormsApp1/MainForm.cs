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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Log Out of the System?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Role role = new Role();
                role.Show();
                this.Hide();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Wxaan soo muuqanaya kaliya Dashboard inta klena wey qarsannayaan

            dashboard1.Visible = true;
            owners1.Visible = false;
            registerWeapon1.Visible = false;
            compenisations1.Visible = false;
            reports1.Visible = false;
            users1.Visible = false;

            dashboard1.DisplayMostState();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            // Wxaan soo muuqanaya kaliya Owner Data ku jirto inta klena wey qarsannayaan

            dashboard1.Visible = false;
            owners1.Visible = true;
            registerWeapon1.Visible = false;
            compenisations1.Visible = false;
            reports1.Visible = false;
            users1.Visible = false; 
        }

        private void btnRegisterWeapon_Click(object sender, EventArgs e)
        {
            // Wxaan soo muuqanaya kaliya Registeration Weaponska  Data ku jirto inta klena wey qarsannayaan

            dashboard1.Visible = false;
            owners1.Visible = false;
            registerWeapon1.Visible = true;
            compenisations1.Visible = false;
            reports1.Visible = false;
            users1.Visible = false;
        }

        private void btnCompenisation_Click(object sender, EventArgs e)
        {
            // Wxaan soo muuqanaya kaliya Compenisation Data ku jirto inta klena wey qarsannayaan

            dashboard1.Visible = false;
            owners1.Visible = false;
            registerWeapon1.Visible = false;
            compenisations1.Visible = true;
            reports1.Visible = false;
            users1.Visible = false;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Wxaan soo muuqanaya kaliya Reportska Data ku jirto inta klena wey qarsannayaan

            dashboard1.Visible = false;
            owners1.Visible = false;
            registerWeapon1.Visible = false;
            compenisations1.Visible = false;
            reports1.Visible = true;
            users1.Visible = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            owners1.Visible = false;
            registerWeapon1.Visible = false;
            compenisations1.Visible = false;
            reports1.Visible = false;
            users1.Visible = true;
        }
    }
}
