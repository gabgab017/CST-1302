using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Create an array to hold the numbers.
            // TODO

            int[] arr = new int[5];


            // Create a Random object.
            // TODO
            Random x = new Random();

            // Fill the array with random numbers, in the range
            // of 0 through 99.
            // TODO
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = x.Next(100);
            }

            // Display the array elements in the Label controls.
            // TODO
            firstLabel.Text = arr[0].ToString();
            secondLabel.Text = arr[1].ToString();
            thirdLabel.Text = arr[2].ToString();
            fourthLabel.Text = arr[3].ToString();
            fifthLabel.Text = arr[4].ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
