using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthdays
{
    public partial class Form1 : Form
    {
        // Dictionary with names and birthdays
        Dictionary<string, string> birthdays =
            new Dictionary<string, string>()
            {
                {"Cameron", "4/17/1998" },
                {"Kathryn", "5/7/1996"  },
                {"Jason",   "1/22/1997" },
                {"Lola",    "5/5/1995"  },
                {"Wesley",  "10/4/1999" }
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Display the names in the ListBox.
            foreach (string name in birthdays.Keys)
            {
                namesListBox.Items.Add(name);
            }
        }

        private void namesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO

            // Get the selected name.
            string selectedName = namesListBox.SelectedItem.ToString();

            // Get the selected person's birthday.
            birthdayLabel.Text = birthdays[selectedName];
        }

        private void birthdayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
