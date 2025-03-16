namespace CalculationStudentMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal physics = decimal.Parse(textBoxPhysics.Text);
            decimal chemistry = decimal.Parse(textBoxChemistry.Text);
            decimal math = decimal.Parse(textBoxMath.Text);

            decimal total = physics + chemistry + math;

            if (physics > 100 || chemistry > 100 || math > 100)
            {
                MessageBox.Show("lagama Weynan karo 100");
                return;
            }





            decimal average = total / 3;

            //lblAverage.Text += ": " + average.ToString();
            everage.Text = average.ToString();
            string grade = "";

            if (average >= 97 && average <= 100)
            {
                grade = "A+";
            }
            else if (average >= 94 && average <= 97)
            {
                grade = "A";
            }
            else if (average >= 90 && average <= 94)
            {
                grade = "A-";
            }
            else if (average >= 87 && average <= 90)
            {
                grade = "B+";
            }
            else if (average >= 84 && average <= 87)
            {
                grade = "B";
            }
            else if (average >= 80 && average <= 84)
            {
                grade = "B-";
            }
            else if (average >= 77 && average <= 80)
            {
                grade = "C+";
            }
            else if (average >= 74 && average <= 77)
            {
                grade = "C-";
            }
            else if (average <= 70 && average <= 74)
            {
                grade = "C";
            }
            else if (average <= 60 && average <= 70)
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }
            //this.grade.Text += ": " + grade;
            label3.Text = grade;
        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TxtBoxStudentName.Clear();
            textBoxPhysics.Clear();
            textBoxChemistry.Clear();
            textBoxMath.Clear();
            lblAverage.Text = lblAverage.Text;
            grade.Text = grade.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
