using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lec5;

namespace lec5Test
{
    
    class GameStub : IGame
    {
        public Mark CurrentTurn => Mark.X;

        public bool MakeMove(int x, int y)
        {
            return true;
        }
    }
}
