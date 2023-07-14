using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDice
{
    class Coin : ITossable
    {
        public int Value { get; set; } = 0;

        public void Toss()
        {
            // TODO
            // Create a random number generator
            Random random = new Random();
            // Get a random number between 0 and 1
            Value = random.Next(0, 2);
        }

        public string HeadsOrTails()
        {
            // TODO
           // If the value is 0, return "Heads", otherwise return "Tails"
           if(Value == 0)
            {
                return "Heads";
            }
            else
            {
                return "Tails";
            }
        }
 


}

}
