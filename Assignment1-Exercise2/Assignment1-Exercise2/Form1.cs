using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment1_Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Select Random Numbers File";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                int total = 0;
                int count = 0;

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int number;
                        if (int.TryParse(line, out number))
                        {
                            Result.Items.Add(number);
                            total += number;
                            count++;
                        }
                    }
                    Result.Items.Add($"There were {count} numbers created.");
                    Result.Items.Add($"The total sum of the numbers is {total}");
                }
            }
        }
    }
}