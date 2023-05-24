namespace Lab3_4
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double speed;
            double hours;
            if (double.TryParse(textBox1.Text, out speed) && double.TryParse(textBox2.Text, out hours))
            {
                // add items to the text box
                int counter = 1;
                while (counter <= hours)
                {
                    listBox1.Items.Add($"After hour {counter}, the distance is {counter * speed}.");
                    counter++;
                }
            }
        
            else
            {
                MessageBox.Show("Error in parsing ..");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}