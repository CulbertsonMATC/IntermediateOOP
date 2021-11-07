using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Culbertson_TicTacToe
{
    class HumanPlayer : Player
    {
        BitArray pieces;
        public HumanPlayer()
        {
            pieces = new BitArray(9, false);
        }

        public BitArray Pieces
        {
            get
            {
                return pieces;
            }
        }

        public override void MakeMove(int position)
        {
            pieces[position] = true;
        }
    }
}
