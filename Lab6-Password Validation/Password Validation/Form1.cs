using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            // TODO
            // Count the uppercase characters in str.
            int uppercaseCount = 0;
            foreach (char x in str)
            {
                if (x.IsUpper(x)) uppercaseCount++)
                {
                    uppercaseCount++;
                }
            }
            // Return the number of uppercase characters.
            return uppercaseCount;
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            // TODO
            // Count the lowercase characters in str.
            int lowercaseCount = 0;
            foreach (char x in str)
            {
                if (x.IsLower(x)) lowercaseCount++)
                {
                    lowercaseCount++;
                }
            }
            // Return the number of uppercase characters.
            return lowercaseCount;
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            // TODO 
            // Count the digits in str.
            // Return the number of digits.
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;  // Password's minimum length

            // Get the password from the TextBox.
            string password = passwordTextBox.Text;

            // Validate the password.
            if (password.Length >= MIN_LENGTH &&
                NumberUpperCase(password) >= 1 &&
                NumberLowerCase(password) >= 1 &&
                NumberDigits(password) >= 1)
            {
                MessageBox.Show("The password is valid.");
            }
            else
            {
                MessageBox.Show("The password does not meet " +
                    "the requirements.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
