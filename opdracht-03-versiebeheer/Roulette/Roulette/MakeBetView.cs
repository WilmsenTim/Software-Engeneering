using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class MakeBetView : UserControl
    {

        private MakeBetController _controllerBet;
        public Label betLbl;
        private Roulette container;
        public MakeBetView(MakeBetController BetC, Roulette r)
        {
            
            InitializeComponent();
            container = r;
            _controllerBet = BetC;
            BetLabel.BackColor = Color.Black;
            BetLabel.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Roulette.player1.MoneySelected= _controllerBet.Amount;
            BetLabel.BackColor = Color.Red;
            

        }


        public void changeBetAmout(int amount)
        {
            BetLabel.Text = Convert.ToString(amount);
        }
    }
}
