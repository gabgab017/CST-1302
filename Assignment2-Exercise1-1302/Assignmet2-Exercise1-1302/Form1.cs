using System.Drawing.Text;

namespace Assignmet2_Exercise1_1302
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int numberOfQuestions = 20;
        private char[] correctAnswers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
        private char[] studentAnswers = { };

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Select Student's answer File";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                studentAnswers = ReadStudentAnswersFromFile(fileName);

                int numCorrect = CalculateNumOfCorrectAnswers();
                int numIncorrect = numberOfQuestions - numCorrect;

                textBox1.Text = (numCorrect >= 15) ? "Pass" : "Fail";
                textBox2.Text = "Correctly answered: " + numCorrect;
                textBox3.Text = "Incorrectly answered: " + numIncorrect;

                if (numIncorrect > 0)
                {
                    incorrectListBox1.Text = "Incorrectly answered questions: ";
                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        if (studentAnswers[i] != correctAnswers[i])
                        {
                            incorrectListBox1.Items.Add("Answer " + (i+1) + " is incorrect. Right answer is " + correctAnswers[i]);
                        }
                    }
                }
            }
        }

        private char[] ReadStudentAnswersFromFile(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                string answers = string.Join("", lines);
                return answers.ToCharArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading student file.");
                return new char[0];
            }
        }

        private int CalculateNumOfCorrectAnswers()
        {
            int numCorrect = 0;
            for (int i = 0; i < numberOfQuestions; i++)
            {
                if (studentAnswers[i] == correctAnswers[i])
                {
                    numCorrect++;
                }
            }
            Console.WriteLine("Number of correct answers: " + numCorrect);
            return numCorrect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void incorrectListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}