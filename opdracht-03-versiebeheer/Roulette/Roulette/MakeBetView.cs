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
        public MakeBetView(MakeBetController BetC)
        {
            
            InitializeComponent();
            _controllerBet = BetC;
            BetLabel.BackColor = Color.Black;
            BetLabel.ForeColor = Color.White;
        }

        public void makeBlack()
        {
            BetLabel.BackColor = System.Drawing.Color.Black;
        }

        public void makeActive()
        {
            Roulette.player1.MoneySelected = _controllerBet.Amount;

            _controllerBet._container.otherBetSelected();
            BetLabel.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Roulette.player1.MoneySelected= _controllerBet.Amount;

            _controllerBet._container.otherBetSelected();
            BetLabel.BackColor = Color.Red;


        }


        public void changeBetAmout(int amount)
        {
            BetLabel.Text = Convert.ToString(amount);
        }
    }
}
