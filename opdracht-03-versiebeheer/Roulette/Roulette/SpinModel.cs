using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public class SpinModel
    {

        private int number;
        private Button spinButton;

        public SpinModel()
        {

        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public Button SpinButton
        {

            get
            {
                return spinButton;
            }
            set
            {
                spinButton = value;
            }

        }

    }
}
