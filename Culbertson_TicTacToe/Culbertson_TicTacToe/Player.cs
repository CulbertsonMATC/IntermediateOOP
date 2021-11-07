using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Culbertson_TicTacToe
{
    public abstract class Player
    {
        BitArray pieces;
        public abstract void MakeMove(int position);  
    }
    
}

