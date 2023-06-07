using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;  // To read the file
                string line;             // To hold a line from the file
                int count = 0;           // Student counter
                int total;               // Accumulator
                double average;          // Test score average

                // Create a delimiter array.
                char[] delim = { ',' };

                // Open the CSV file.
                inputFile = File.OpenText("Grades.csv");

                while (!inputFile.EndOfStream)
                {
                    // TODO
                    // Increment the student counter.
                    count++;

                    // Read a line from the file.
                    line = inputFile.ReadLine();

                    // Get the test scores as tokens.
                    string[] scores = line.Split(delim);

                    // Set the accumulator to 0.
                    total = 0;

                    // Calculate the total of the
                    // test score tokens.
                    foreach(string score in scores)
                        total += int.Parse(score);

                    // Calculate the average of these
                    // test scores.
                    average = total / scores.Length;

                    // Display the average.
                    averagesListBox.Items.Add(average);
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
