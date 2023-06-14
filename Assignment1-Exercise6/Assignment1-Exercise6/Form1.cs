namespace Assignment1_Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalculatePresentValue(decimal futureValue, decimal interestRate, int numYears)
        {
            decimal presentValue = futureValue / (decimal)Math.Pow(1 + (double)interestRate, numYears);
            return presentValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal futureValue = 10000.00m;
            decimal interestRate = 0.05m;
            int numYears = 10;

            decimal presentValue = CalculatePresentValue(futureValue, interestRate, numYears);
            textBox1.Text = presentValue.ToString("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}