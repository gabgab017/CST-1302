namespace Assignment1_Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int FatCalories(int fatGrams)
        {
            int caloriesFromFat = fatGrams * 9;
            return caloriesFromFat;
        }

        private int CarbCalories(int carbGrams)
        {
            int caloriesFromCarbs = carbGrams * 4;
            return caloriesFromCarbs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int fatGrams))
            {
                MessageBox.Show("Please input whole numbers.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(textBox2.Text, out int carbGrams))
            {
                MessageBox.Show("Please input whole numbers.", "Error", MessageBoxButtons.OK);
                return;
            }

            int caloriesFromFat = FatCalories(fatGrams);
            int caloriesFromCarbs = CarbCalories(carbGrams);

            Result.Items.Clear();
            Result.Items.Add($"Calories from fat: {caloriesFromFat}");
            Result.Items.Add($"Calories from carbs: {caloriesFromCarbs}");

            Result.Items.Add($"The total number of calories you eat a day is: " + (caloriesFromFat + caloriesFromCarbs));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
