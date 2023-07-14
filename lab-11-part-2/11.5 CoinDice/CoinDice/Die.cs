using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDice
{
    class Die : ITossable
    {
        public int Value { get; set; } = 1;

        public void Toss()
        {
            // TODO
            // Random number generator
            // Generate a number between 1 and 6
        }
    }
}
