using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {

        /*
            TODO:
        
            yahtzee spel

 

        */
        public Yahtzee()
        {
           InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScoreboardController scoreboard = new ScoreboardController();

            Controls.Add(scoreboard.getView());

            int aantalTeerlingen = 3;

            List<TeerlingController> teerlingen = new List<TeerlingController>();

            //doe alle teerlingen in een list
            for (int teerlingNr = 0; teerlingNr < aantalTeerlingen; ++teerlingNr)
            {
                TeerlingController newTeerling = new TeerlingController(scoreboard);
                teerlingen.Add(newTeerling);
            }

            //voeg teerlingen aan formulier
            for (int teerlingNr = 0; teerlingNr < aantalTeerlingen; ++teerlingNr)
            {

                TeerlingView thisView = teerlingen[teerlingNr].getView();
                int xPos = thisView.Width * teerlingNr;
                thisView.Location = new Point(xPos, 50);

                Controls.Add(thisView);
                
            }

            this.Width = aantalTeerlingen * teerlingen[1].getView().Width;

            WerpController werpCtrl = new WerpController();
            WerpView werpView = werpCtrl.getView();
            werpView.Location = new Point((this.Width / 2) - (werpView.Width / 2), 350);

            //load teerlingen in werper model
            werpCtrl.addTeerlingen(teerlingen);

            Controls.Add(werpView);


        }
    }
}
