using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using System.Windows.Forms;

namespace Roulette
{
    public partial class Roulette : Form
    {
        public string name = "Player";
        public int moneySelected = 0;
        public int money = 5000;
        public static PlayerStats player1 = new PlayerStats("Speler1", 500);

        private RouletteController _controller;

        List<MakeBetController> bets = new List<MakeBetController>();
        List<BoardController> numbers = new List<BoardController>();
        List<SpinController> spin = new List<SpinController>();


        BoardController zero;


        MoneyController moneyC;
        MoneyView moneyV;


        //public bool newSpin = false;

        public Roulette(RouletteController rC)
        {
            _controller = rC;
            InitializeComponent();
        }

        public Roulette()
        {
            InitializeComponent();
        }



        private void Roulette_Load(object sender, EventArgs e)
        {
            Console.WriteLine(money);
            int aantalNummers = 1;
            int marginHorizontal = 5;
            int marginVertical = 5;
            int marginLeftFromNumbers = 50;


            ////////// SPIN START //////////
            for (int spinNummer = 0; spinNummer < aantalNummers; ++spinNummer)
            {
                // Maak instantie aan van spinController
                SpinController tijdelijkeTeerling = new SpinController(this);

                spin.Add(tijdelijkeTeerling);
            }

            // spin tonen
            for (int spinNummer = 0; spinNummer < aantalNummers; ++spinNummer)
            {
                // Maak instantie aan van spinController
                SpinView spinView = spin[spinNummer].getView();

                // breedte van spinner ophalen en positie berekenen (0 * breedte spin, ...)
                int horizontalPosition = spinNummer * spinView.Width;

                spinView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(spinView);
            }
            ////////// SPIN END //////////



            ////////// BOARD START //////////

            //controllers maken
            for (int i = 0; i < 36; i++)
            {
                BoardController tmpBoardControl = new BoardController(this);
                numbers.Add(tmpBoardControl);
            }

            //variabelen om grid te maken
            int heightAmount = 0;
            int widthAmount = 0;

            //laten zien
            for (int i = 0; i < 36; i++)
            {
                BoardView boardView = numbers[i].getView();


                int horizontalPosition = aantalNummers * spin[0].getView().Width + marginLeftFromNumbers + widthAmount * (boardView.Width + marginHorizontal);
                int verticalPosition = (heightAmount * (boardView.Height + marginVertical)) + 10;
                boardView.Location = new System.Drawing.Point(horizontalPosition, verticalPosition);
                heightAmount++;
                if (heightAmount == 3)
                {
                    heightAmount = 0;
                    widthAmount++;
                }

                boardView.setNumber(i + 1);
                boardView.setColour();
                Controls.Add(boardView);
            }
            // 0 button
            zero = new BoardController(this);
            BoardView zeroView = zero.getView();

            zeroView.setNumber(0);
            zeroView.resize(numbers[0].getView().Height * 3 + marginVertical * 2);
            zeroView.Location = new System.Drawing.Point(spin[0].getView().Width + 6, 10);
            zeroView.setColour();
            ///
            ////////// BOARD END //////////


            ////////// BET START //////////
            int[] betAmounts = { 1, 5, 25, 100, 500 };


            for (int i = 0; i < betAmounts.Length; i++)
            {
                MakeBetController tempBet = new MakeBetController(betAmounts[i], this);
                bets.Add(tempBet);
            }
            int amountBetsAdded = 0;
            bool makeFirstActive = true;
            for (int i = 0; i < betAmounts.Length; i++)
            {
                MakeBetView betView = bets[i].getView();
                if (makeFirstActive)
                {
                    bets[i].getView().makeActive();
                    makeFirstActive = false;
                }
                betView.Location = new System.Drawing.Point(500 + bets[0].getView().Width * amountBetsAdded, spin[0].getView().Height - betView.Height);
                amountBetsAdded++;
                Controls.Add(betView);
            }

            MakeBetController bet1 = new MakeBetController(1, this);
            MakeBetView bet1View = bet1.getView();
            bet1View.Location = new System.Drawing.Point(500, spin[0].getView().Height - bet1View.Height);
            Controls.Add(bet1View);
            ////////// BET END //////////



            Controls.Add(zeroView);


            /////MONEY/////
            moneyC = new MoneyController(this);
            moneyV = moneyC.getView();

            moneyV.Location = new System.Drawing.Point(spin[0].getView().Width + 5, spin[0].getView().Height - moneyC.getView().Height);
            Controls.Add(moneyV);
            /////MONEY END/////

        }


        public void otherBetSelected()
        {
            foreach (MakeBetController tempBetController in bets)
            {
                tempBetController.getView().makeBlack();

            }
        }



        public bool checkNumber()
        {


            foreach (BoardController boardnumber in numbers) {

                if (boardnumber._boardModel.BetAmount > 0) {

                    return true;
                }

            }

            return false;
        }

        public void compareNumbers(int number)
        {

            int MoneyAmount = Roulette.player1.Money;

            int profit = 0;

            int i = 0;

            foreach (BoardController boardnumber in numbers)
            {
                i++;

                if (boardnumber._boardModel.BetAmount > 0)
                {

                    if (number == i)
                    {
                        profit = boardnumber._boardModel.BetAmount * (boardnumber._boardModel.BetAmount / 100);

                        moneyV.changeMoney(money + profit);

                    }
                    else
                    {
                        profit = boardnumber._boardModel.BetAmount;

                        moneyV.changeMoney(money - profit);
                    }
                }

            }

        }

        public void resetBet() {

            foreach (BoardController boardnumber in numbers) {


                if (boardnumber._boardModel.BetAmount > 0) {

                    boardnumber._boardModel.BetAmount = 0;
                    boardnumber._boardView.betText.Text = "";

                    //if (boardnumber._boardView.betText.Text == "")
                    //{

                    //    newSpin = true;

                    //}

                    //else {

                    //    newSpin = false;

                    //}

                }

            }

        }

    }
}
