using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAT_Scores
{
    public partial class Form1 : Form
    {
        // List of students and their SAT scores
        private List<StudentScore> studentList = new List<StudentScore>()
        {
            new StudentScore("Jess Adams", 1275),
            new StudentScore("Dennis Bailey", 1060),
            new StudentScore("Ashley Carter", 1155),
            new StudentScore("Rebecca Ferguson Foster", 1310),
            new StudentScore("Sarah Green", 975),
            new StudentScore("Claudia Kelly", 1260),
            new StudentScore("Brandon Parker", 1055),
            new StudentScore("Timothy Ward", 920)
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the studentListBox
            foreach(var student in studentList)
            {
                studentListBox.Items.Add(
                    student.Name + " (" + student.Score + ")");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int minScore;

            // Get the minimum score
            if (int.TryParse(scoreTextBox.Text, out minScore))
            {
                // Clear the resultsListBox
                resultsListBox.Items.Clear();

                // Get the students with a score greater than minScore.
                // TODO
                // List<StudentScore> results = ? 
                Predicate<StudentScore> scoreGreaterThanMinScore = (StudentScore student) => student.Score > minScore;
                List<StudentScore> results = studentList.FindAll(scoreGreaterThanMinScore);

                //OR List<StudentScore> results = studentList.FindAll(
                // (StudentScore student) => student.Score > minScore
                //    );

                // Display those students.
                foreach (var student in results)
                {
                    resultsListBox.Items.Add(
                        student.Name + " (" + student.Score + ")");
                }
            }
            else
            {
                MessageBox.Show("Enter an integer score.");
            }
        }
    }
}
