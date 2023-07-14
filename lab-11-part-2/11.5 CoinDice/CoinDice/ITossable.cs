using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDice
{
    interface ITossable
    {
        int Value { get; set; }
        void Toss();
    }
}
