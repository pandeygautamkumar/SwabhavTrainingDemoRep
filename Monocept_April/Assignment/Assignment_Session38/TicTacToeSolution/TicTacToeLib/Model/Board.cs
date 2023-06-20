﻿

namespace TicTacToeLib.Model
{
    public class Board
    {
        private Cell[] _cells;
        public Board()
        {
            _cells = new Cell[9];
            InitializeCells();
        }
        private void InitializeCells()
        {
            for (int i = 0; i < 9; i++)
            {
                _cells[i] = new Cell();
            }
        }
        public void MarkCell(int cellPosition,MarkType mark)
        {
            _cells[cellPosition].Mark = mark;
        }
        public bool IsBoardFull()
        {
            for(int i = 0; i < _cells.Length; i++)
            {
                if (!_cells[i].IsAlreadyMarked())
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsEmpty()
        {
            for(int i = 0; i < _cells.Length; i++)
            {
                if (_cells[i].IsAlreadyMarked())
                {
                    return false;
                }
            }
            return true;
        }
        public Cell[] Cells { get { return _cells; } }

    }
}
