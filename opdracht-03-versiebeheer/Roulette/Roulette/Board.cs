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
    public partial class BoardView : UserControl
    {
        private BoardController _controllerBoard;
        public Label boardLbl;
        public Label betText;

        public BoardView(BoardController BoardC)
        {
            InitializeComponent();

            _controllerBoard = BoardC;
            Number.Font = new Font(Number.Font.FontFamily, Number.Font.Size, Number.Font.Style);
            Number.ForeColor = Color.White;
            Bet.ForeColor = Color.White;
            boardLbl = Number;
            betText = Bet;

            if(Bet.Text == "0")
            {
                Bet.Text = "";
            }
            





    }

        public void setColour()
        {
            int currentNumber = Int32.Parse(Number.Text);
            //Console.WriteLine(currentNumber);
            if ((currentNumber > 0 && currentNumber < 11) || (currentNumber > 18))
            {
                if (IsOdd(currentNumber))
                {
                    Number.BackColor = Color.Red;
                    Bet.BackColor = Color.Black;
                }
                else
                {
                    Number.BackColor = Color.Black;
                    Bet.BackColor = Color.Red;
                }

            }
            else
            {
                if (IsOdd(currentNumber))
                {
                    Number.BackColor = Color.Black;
                    Bet.BackColor = Color.Red;
                }
                else
                {
                    Number.BackColor = Color.Red;
                    Bet.BackColor = Color.Black;
                }
            }

            if(Number.Text == "0")
            {
                Number.BackColor = Color.White;
                Number.ForeColor = Color.Black;
            }
        }

        public void setNumber(int nr)
        {
            Number.Text = nr.ToString();
        }


        public void resize(int width, int height)
        {
            Number.Size = new Size(width, 50);
        }

        public void resize(int height)
        {
            Number.Size = new Size(Number.Size.Width, height);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {


            if (Roulette.player1.MoneySelected > 0)
            {
                string betAmount = "";
                int itIsANumber;
                bool CheckIfNumber = int.TryParse(Bet.Text, out itIsANumber);
                if (CheckIfNumber)
                {
                    betAmount = (itIsANumber + Roulette.player1.MoneySelected).ToString();
                    //Console.WriteLine((Convert.ToInt32(Bet.Text) + 5).ToString());
                    _controllerBoard._boardModel.BetAmount = itIsANumber + Roulette.player1.MoneySelected;
                }
                else
                {
                    betAmount = Roulette.player1.MoneySelected.ToString();
                    _controllerBoard._boardModel.BetAmount = Roulette.player1.MoneySelected;
                    
                }
                Bet.Text = betAmount;
                //Console.WriteLine(_controllerBoard._boardModel.BetAmount);
                //Console.WriteLine(itIsANumber);
                

            }
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        private void BoardView_Load(object sender, EventArgs e)
        {

        }

        private void Bet_Click(object sender, EventArgs e)
        {

        }
    }


}
