using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingController
    {
        private TeerlingView _view;
        public TeerlingModel _model;
        private ScoreboardController _scoreCtrl;

        public TeerlingController(ScoreboardController scoreCtrl)
        {
            _view = new TeerlingView(this, scoreCtrl);
            _model = new TeerlingModel();
            _scoreCtrl = scoreCtrl;
        }

        public void werpTeerling()
        {
            Random rnd = new Random();
            int nieuwGetal = rnd.Next(1, 7);
        
            _model.teerling = nieuwGetal;
            _scoreCtrl.addWorp();
        }

        public TeerlingView getView()
        {
            return _view;
        }


    }
}
