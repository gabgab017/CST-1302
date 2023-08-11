namespace Assignment4_Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ProcessAndDisplayNumbers(filePath);
                }
            }
        }

        private void ProcessAndDisplayNumbers(string filePath)
        {
            List<int> numbers;


            string[] lines = File.ReadAllLines(filePath);
            numbers = new List<int>();

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    numbers.Add(number);
                }
            }

            // RemoveAll method - removing all negative numbers if there is any.
            numbers.RemoveAll(n => n < 0);

            // FindAll method - finding al the numbers ranging from 1 to 10.
            List<int> rangeNumbers = numbers.FindAll(n => n >= 1 && n <= 10);

            listBox1.Items.Clear();

            foreach (var number in rangeNumbers)
            {
                listBox1.Items.Add(number);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}