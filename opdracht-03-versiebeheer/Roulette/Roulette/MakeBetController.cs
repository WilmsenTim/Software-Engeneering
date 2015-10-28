using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class MakeBetController
    {
        private MakeBetView _betView;
        public int Amount;

        public MakeBetController(int initAmount,Roulette r)
        {
            _betView = new MakeBetView(this,r);
            Amount = initAmount;
            _betView.changeBetAmout(Amount);
        }

        public MakeBetView getView()
        {
            return _betView;
        }

    }
}
