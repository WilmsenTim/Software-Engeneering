using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public class MoneyModel
    {

        private int moneyAmount = 0;
        

        public MoneyModel() { }

        public int MoneyAmount
        {

            get
            {
                return moneyAmount;
            }
            set
            {
                moneyAmount = value;
            }
        }

        

    }
}
