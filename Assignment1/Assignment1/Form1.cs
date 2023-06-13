namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Random Numbers";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                int count;
                if (!int.TryParse(textBox1.Text, out count) || count <= 0)
                {
                    MessageBox.Show("Invalid input. Please enter a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Random random = new Random();
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    for (int i = 0; i < count; i++)
                    {
                        int randomNumber = random.Next(1, 101);
                        writer.WriteLine(randomNumber);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
