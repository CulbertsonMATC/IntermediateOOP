using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_TicTacToe
{
    class Board
    {
        int[,] winningCombos = { {0,1,2},
                                 {3,4,5},
                                 {6,7,8},
                                 {0,3,6},
                                 {1,4,7},
                                 {2,5,8},
                                 {0,4,8},
                                 {2,4,6} };

        int count;

        public Board()
        {
            count = 0;
        }

        public bool IsWinner(Player thePlayer)
        {
            bool winner = false;    

            for (int i = 0; i < winningCombos.GetLength(0); i++)
            {
                if ((thePlayer.Pieces[winningCombos[i, 0]]) && (thePlayer.Pieces[winningCombos[i, 1]]) && (thePlayer.Pieces[winningCombos[i, 2]]))
                    winner = true;
            }
            return winner;
        }

        public bool IsFull()
        {
            bool tie = false;

            if (count >= 8)
                tie = true;

            count++;

            return tie;
        }


    }
}
