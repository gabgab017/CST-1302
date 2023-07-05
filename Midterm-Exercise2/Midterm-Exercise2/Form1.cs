namespace Midterm_Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);
            double area = radius * radius;
            textBox2.Text = area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal height = decimal.Parse(textBox3.Text);
            decimal length = decimal.Parse(textBox4.Text);
            decimal area = (height * length) / 2;
            textBox5.Text = area.ToString();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox6.Text, out decimal radius) && decimal.TryParse(textBox7.Text, out decimal height))
            {
                decimal phi = 3.141592653589793238m;
                decimal area = (2 * phi * radius * height) + (2 * phi * (radius * radius));
                textBox8.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("IOnvalid entry for radius and/or height.");
            }
        }
    }
}