using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class BoardController
    {
        public Roulette _container;

        private BoardView _boardView;
        public BoardModel _boardModel;

        public BoardController(Roulette container)
        {

            _container = container;

            _boardView = new BoardView(this);
            _boardModel = new BoardModel();
        }

        public BoardView getView()
        {
            return _boardView;
        }

    }
}
