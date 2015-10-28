using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class RouletteController
    {
        private Roulette _rouletteView;



        public RouletteController()
        {
            _rouletteView = new Roulette(this);
        }


        public Roulette getView() {
            return _rouletteView;
        }

    }
}
