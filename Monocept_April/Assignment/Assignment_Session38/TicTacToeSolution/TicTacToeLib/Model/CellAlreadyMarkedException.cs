using System;

namespace TicTacToeLib.Model
{
    public class CellAlreadyMarkedException : Exception
    {
        public CellAlreadyMarkedException(string msg):base(msg)
        {

        }
    }
}
