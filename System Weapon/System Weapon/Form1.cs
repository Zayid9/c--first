namespace System_Weapon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 767)
            {
                timer1.Stop();

                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
