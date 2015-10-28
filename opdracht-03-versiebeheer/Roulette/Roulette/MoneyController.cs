using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class MoneyController
    {

        public Roulette _Container;

        private MoneyModel _moneyModel;
        private MoneyView _moneyView;

        public MoneyController(Roulette r) {

            _Container = r;

            _moneyView = new MoneyView(this);
            _moneyModel = new MoneyModel();
        }


        public MoneyView getView() {

            return _moneyView;
        }

    }
}
