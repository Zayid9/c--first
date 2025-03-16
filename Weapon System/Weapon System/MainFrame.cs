using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weapon_System
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void RefreshData(Form form)
        {
            if (form != null)
            {
                MethodInfo refreshMethod = form.GetType().GetMethod("RefreshData");
                if (refreshMethod != null)
                {
                    refreshMethod.Invoke(form, null);
                }
            }
        }

        private void ShowDashboard()
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //btnDashboard.Visible = true;
            //btnOwner.Visible = false;
            //btnState.Visible = false;
            //btnLocation.Visible = false;
            //btnCat.Visible = false;
            //btnRegisterWeapon.Visible = false;
            //btnComponisation.Visible = false;

            //Dashboard dashboard_Form = new Dashboard();
            //if (dashboard_Form != null)
            //{
            //    dashboard_Form.Refresh();
            //}

            Dashboard dashboard_Form = new Dashboard();
            RefreshData(dashboard_Form);
        }

        private void RefreshData(Dashboard dashboard_Form)
        {
            throw new NotImplementedException();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            //btnDashboard.Visible = false;
            //btnOwner.Visible = true;
            //btnState.Visible = false;
            //btnLocation.Visible = false;
            //btnCat.Visible = false;
            //btnRegisterWeapon.Visible = false;
            //btnComponisation.Visible = false;

            //Owner Owner_Form = new Owner();
            //if (Owner_Form != null)
            //{
            //    Owner_Form.Refresh();
            //}

            Owner owner_Form = new Owner();
            RefreshData(owner_Form);
        }

        private void RefreshData(Owner owner_Form)
        {
            throw new NotImplementedException();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            //    btnDashboard.Visible = false;
            //    btnOwner.Visible = false;
            //    btnState.Visible = true;
            //    btnLocation.Visible = false;
            //    btnCat.Visible = false;
            //    btnRegisterWeapon.Visible = false;
            //    btnComponisation.Visible = false;

            //    State State_Form = new State();
            //    if (State_Form != null)
            //    {
            //        State_Form.Refresh();
            //    }

            State state_Form = new State();
            RefreshData(state_Form);
        }

        private void RefreshData(State state_Form)
        {
            throw new NotImplementedException();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            //btnDashboard.Visible = false;
            //btnOwner.Visible = false;
            //btnState.Visible = false;
            //btnLocation.Visible = true;
            //btnCat.Visible = false;
            //btnRegisterWeapon.Visible = false;
            //btnComponisation.Visible = false;

            //Location Location_Form = new Location();
            //if (Location_Form != null)
            //{
            //    Location_Form.Refresh();
            //}

            Location location_Form = new Location();
            RefreshData(location_Form);
        }

        private void RefreshData(Location location_Form)
        {
            throw new NotImplementedException();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            //btnDashboard.Visible = false;
            //btnOwner.Visible = false;
            //btnState.Visible = false;
            //btnLocation.Visible = false;
            //btnCat.Visible = true;
            //btnRegisterWeapon.Visible = false;
            //btnComponisation.Visible = false;

            //Cat Cat_Form = new Cat();
            //if (Cat_Form != null)
            //{
            //    Cat_Form.Refresh();
            //}

            Cat cat_Form = new Cat();
            RefreshData(cat_Form);
        }

        private void RefreshData(Cat cat_Form)
        {
            throw new NotImplementedException();
        }

        private void btnRegisterWeapon_Click(object sender, EventArgs e)
        {
            //btnDashboard.Visible = false;
            //btnOwner.Visible = false;
            //btnState.Visible = false;
            //btnLocation.Visible = false;
            //btnCat.Visible = false;
            //btnRegisterWeapon.Visible = true;
            //btnComponisation.Visible = false;

            //Register Register_Form = new Register();
            //if (Register_Form != null)
            //{
            //    Register_Form.Refresh();
            //}

            Register register_Form = new Register();
            RefreshData(register_Form);
        }

        private void RefreshData(Register register_Form)
        {
            throw new NotImplementedException();
        }

        private void btnComponisation_Click(object sender, EventArgs e)
        {
            //btnDashboard.Visible = false;
            //btnOwner.Visible = false;
            //btnState.Visible = false;
            //btnLocation.Visible = false;
            //btnCat.Visible = false;
            //btnRegisterWeapon.Visible = false;
            //btnComponisation.Visible = true;

            //Dashboard dashboard_Form = new Dashboard();
            //if (dashboard_Form != null)
            //{
            //    dashboard_Form.Refresh();
            //}
        }
    }
}
