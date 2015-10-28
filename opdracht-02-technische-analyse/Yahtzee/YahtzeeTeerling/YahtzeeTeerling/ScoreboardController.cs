using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class ScoreboardController
    {
        ScoreboardModel _model;
        ScoreboardView _view;

        public ScoreboardController()
        {
            _view = new ScoreboardView(this);
            _model = new ScoreboardModel();
        }

        public void addWorp()
        {
            _model.aantalWorpen++;
            _view.updateWorpen();
        }

        public ScoreboardView getView()
        {
            return _view;
        }

    }
}
