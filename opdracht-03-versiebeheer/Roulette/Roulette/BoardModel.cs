using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class BoardModel
    {
        int betAmount = 0;

        public int BetAmount
        {

            get
            {
                return betAmount;
            }
            set
            {
                betAmount = value;
            }
        }


    }
}
