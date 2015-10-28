using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class TeerlingView : UserControl
    {
        private TeerlingController _controllerTeerling;
        private ScoreboardController _controllerScore;

        public TeerlingView(TeerlingController teerlingCtrl, ScoreboardController scoreboardCtrl)
        {
            _controllerTeerling = teerlingCtrl;
            _controllerScore = scoreboardCtrl;
            InitializeComponent();
        }

        public void updateView(string text)
        {
            this.lbl_teerling.Text = text;
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
     
        }

        private void btn_werp_Click(object sender, EventArgs e)
        {
            if(_controllerTeerling._model.isVast)
            {
                return;
            }

            _controllerTeerling.werpTeerling();

            updateView(_controllerTeerling._model.teerling.ToString());

            _controllerTeerling._model.isVast = true;
      
        }

        private void lbl_teerling_Click(object sender, EventArgs e)
        {

        }
    }
}
