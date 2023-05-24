namespace Lab3Part2
{
    public partial class Form1 : Form
    {
        public Form1()  
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            double organisms;
            double averageDailyIncrease;
            double days;
            if (double.TryParse(textBox1.Text, out organisms) &&
                double.TryParse(textBox2.Text, out averageDailyIncrease) &&
                double.TryParse(textBox3.Text, out days))
            {
                // add items to the text box
                int counter = 1;
                listBox1.Items.Add($"Day \t App. Population");
                double sum = organisms;
                while (counter <= days)
                {
                    listBox1.Items.Add($"{counter} \t {sum}");
                    sum = sum * (1 + averageDailyIncrease / 100);
                    counter++; 
                }

            }
            else
            {
                MessageBox.Show("Error in parsing ..");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
} 