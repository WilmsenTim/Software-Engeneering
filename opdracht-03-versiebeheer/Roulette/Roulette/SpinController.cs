using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roulette
{
    public class SpinController
    {

        public Roulette _container;

        public  SpinView _spinView;
        public SpinModel _spinModel;

        public SpinController( Roulette container) {

            _container = container;

            _spinView = new SpinView(this);
            _spinModel = new SpinModel();
        }

        public void spinBal() {

            Random random = new Random();

            // Getal berekenen tussen 1 & 36
            int randomNumber = random.Next(0, 36);

            if (randomNumber == 1 || randomNumber == 3 || randomNumber == 5 || randomNumber == 9 || randomNumber == 7 || randomNumber == 14 || randomNumber == 16 || randomNumber == 18 || randomNumber == 21 || randomNumber == 19 || randomNumber == 23 || randomNumber == 25 || randomNumber == 27 || randomNumber == 30 || randomNumber == 32 || randomNumber == 36 || randomNumber == 34)
            {
                _spinView.spinlbl.BackColor = Color.Red;
                _spinView.spinlbl.ForeColor = Color.Black;
            }

            else if( randomNumber == 0) {

                _spinView.spinlbl.BackColor = Color.White;
                _spinView.spinlbl.ForeColor = Color.Black;
            }

            else
            {
                _spinView.spinlbl.BackColor = Color.Black;
                _spinView.spinlbl.ForeColor = Color.White;
            }

            // Het model updaten
            _spinModel.Number = randomNumber;

        }

        public SpinView getView() {

            return _spinView;

        }

    }
}
