using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods
{
    static class Extensions
    {
        public static string EuroDate(this string str)
        {
            string euroFormat;                  // To hold the result
            char[] delim = { '/' };             // Token delimiter
            string[] tokens = str.Split(delim); // Tokenize the string

            // TODO
            // Validate the number of tokens and return the result.
            if (tokens.Length != 3)
            {
                throw new ArgumentException("Invalid date format.mm/dd/yyyy.");
            }

            int month = int.Parse(tokens[0]);
            int day = int.Parse(tokens[1]);
            int year = int.Parse(tokens[2]);

            euroFormat = $"{day}/{month}/{year}"

            return euroFormat;
        }
    }
}
