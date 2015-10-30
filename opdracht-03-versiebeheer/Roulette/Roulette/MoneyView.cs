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
    public partial class MoneyView : UserControl
    {

        private MoneyController _controller;

        public Label starter_money;

        public MoneyView(MoneyController c)
        {
            _controller = c;

            InitializeComponent();
            changeMoney(_controller._Container.money);

            lbl_money.Font = new Font(lbl_money.Font.FontFamily, lbl_money.Font.Size + 10f, lbl_money.Font.Style);
            lbl_money.ForeColor = Color.White;
        }


        public void changeMoney(int amount)
        {
            if (amount >= 0)
            {
                lbl_money.Text = "Money: " + amount.ToString();
            }
            else
            {
                lbl_money.Text = "You have no more money";
            }
            _controller._Container.money = amount;
        }
    }
}
