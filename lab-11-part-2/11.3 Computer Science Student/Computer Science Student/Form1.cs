using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Science_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            // Variables to hold input
            string name, id, track;

            // TODO
            // Get the student's name and ID.
            name = nameTextBox.Text;
            id = idTextBox.Text;

            // Get the student's academic track.
            track = trackTextBox.Text;


            // Create a CompSciStudent object.
            CompSciStudent student = new CompSciStudent(track);

            // Display the student's required hours.
            MessageBox.Show($"Name: {name}\nID: {id}\nRequired hours: {student.RequiredHours}");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
