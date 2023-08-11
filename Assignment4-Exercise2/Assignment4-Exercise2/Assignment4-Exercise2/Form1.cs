using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Assignment4_Exercise2
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ProcessAndDisplayWords(filePath);
                }
            }
        }

        private void ProcessAndDisplayWords(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            var words = (from line in lines
                         from word in line.Split(' ')
                         let cleanedWord = RemoveExtraChar(word).ToLower()
                         where !string.IsNullOrWhiteSpace(cleanedWord) && !char.IsDigit(cleanedWord[0])
                         select cleanedWord).Distinct().ToList();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(words.ToArray());
        }

        private string RemoveExtraChar(string word)
        {
            while (word.Length > 0 &&
                   (word[word.Length - 1] == ';' ||
                    word[word.Length - 1] == '.' ||
                    word[word.Length - 1] == ',' ||
                    word[word.Length - 1] == ')' ||
                    word[word.Length - 1] == '!' ||
                    word[word.Length - 1] == '?' ||
                    //word[word.Length - 1] == ',"' ||
                    word[word.Length - 1] == '`' ||
                    word[word.Length - 1] == '-'))
            {
                word = word.Substring(0, word.Length - 1);
            }

            while (word.Length > 0 &&
                   (word[0] == '(' ||
                    word[0] == '"' ||
                    word[0] == '-'))
            {
                word = word.Substring(1);
            }

            return word;
        }

    }
}

