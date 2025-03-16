namespace MethodPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Add(int number1, int number2)
        {
            //int result = number1 + number2;
            //return result;
            return number1 + number2;
        }

        private int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        private int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        private decimal Divide(decimal number1, decimal number2)
        {
            return number1 / number2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtBoxNumber1.Text);
            int number2 = int.Parse(txtBoxNumber2.Text);

            int result = Add(number1, number2);

            txtBoxResult.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int result = Subtract(int.Parse(txtBoxNumber1.Text), int.Parse(txtBoxNumber2.Text));

            txtBoxResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int result = Multiply(int.Parse(txtBoxNumber1.Text), int.Parse(txtBoxNumber2.Text));

            txtBoxResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal result = Divide(decimal.Parse(txtBoxNumber1.Text), decimal.Parse(txtBoxNumber2.Text));

            txtBoxResult.Text = result.ToString();
        }

        private void ExitForm()
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }
    }
}