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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Log Out of the System?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm Lform = new LoginForm();
                Lform.Show();
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            owner1.Visible = false;
            registerWeapon1.Visible = false;
            componisations1.Visible = false;
            reports1.Visible = false;
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            owner1.Visible = true;
            registerWeapon1.Visible = false;
            componisations1.Visible = false;
            reports1.Visible = false;
        }

        private void btnRegisterWeapon_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            owner1.Visible = false;
            registerWeapon1.Visible = true;
            componisations1.Visible = false;
            reports1.Visible = false;
        }

        private void btnComponisations_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            owner1.Visible = false;
            registerWeapon1.Visible = false;
            componisations1.Visible = true;
            reports1.Visible = false;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            owner1.Visible = false;
            registerWeapon1.Visible = false;
            componisations1.Visible = false;
            reports1.Visible = true;
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
