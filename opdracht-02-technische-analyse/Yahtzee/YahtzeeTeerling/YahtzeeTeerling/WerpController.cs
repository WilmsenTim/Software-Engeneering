using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace YahtzeeTeerling
{
    public class WerpController
    {
        private WerpModel _model;
        private WerpView _view;

        int aantalWorpen = 3;

        public WerpController()
        {
            _model = new WerpModel();
            _view = new WerpView(this);
        }

        public void addTeerlingen(List<TeerlingController> teerlingen)
        {
            _model.teerlingen = teerlingen;
        }

     
        public void werpAlles()
        {
            List<TeerlingController> teerlingen = _model.teerlingen;

            if (aantalWorpen > 0)
            {

                foreach (TeerlingController teerling in teerlingen)
                {

                

                    teerling.werpTeerling();
                    Thread.Sleep(10);
                    teerling._model.isVast = true;
                    teerling.getView().updateView(teerling._model.teerling.ToString());
                
                }

                aantalWorpen--;

            }

        }

        public WerpModel getModel()
        {
            return _model;
        }

        public WerpView getView()
        {
            return _view;
        }
    }
}
