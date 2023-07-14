using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinDice
{
    public partial class Form1 : Form
    {
        // TODO
        // Create Fields for the coin and the die
  

        public Form1()
        {
            InitializeComponent();
        }

        private void tossCoinButton_Click(object sender, EventArgs e)
        {
            // TODO

            // Toss the coin.
            Coin.Toss();
            // Display the side that is up.
            coinLabel.Text = Coin.HeadsOrTails();
        }

        private void tossDieButton_Click(object sender, EventArgs e)
        {
            // TODO

            // Toss the die.
            Die.Toss();
            // Display the side that is up.
            dieLabel.Text = die.Value.ToString();
        }
    }
}
