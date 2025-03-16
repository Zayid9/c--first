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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Wxuu qabanayaa Form loadka Kowaad ee soo muuqanaya

            panel2.Width += 6;

            if(panel2.Width > 575)
            {
                timer1.Stop();


                Role role = new Role();
                role.Show();
                this.Hide();

            }
        }
    }
}
