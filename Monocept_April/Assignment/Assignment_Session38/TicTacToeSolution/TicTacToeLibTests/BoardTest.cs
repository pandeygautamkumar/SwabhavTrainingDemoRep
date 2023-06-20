
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void Constructor_Board_Should_Have_9_Empty_Cells()
        {
            Board board = new Board();
            Assert.IsTrue(board.Cells.Length == 9);
            for(int i=0;i<board.Cells.Length;i++)
            {
                Assert.IsTrue(board.Cells[i].Mark == MarkType.Empty);
            }
        }
        [TestMethod]
        public void MarkCell_Specific_Cell_In_Board_Must_Be_Marked_With_X_or_O()
        {
            Board board = new Board();
            board.MarkCell(cellPosition: 8, mark: MarkType.X);
            Assert.IsTrue(board.Cells[8].Mark == MarkType.X);
        }
        [TestMethod,ExpectedException(typeof(CellAlreadyMarkedException))]
        public void MarkCell_Should_Throw_Exception_If_Same_CellPosition_Marked()
        {
            Board board = new Board();
            board.MarkCell(cellPosition:8, mark: MarkType.X);
            board.MarkCell(cellPosition: 8, mark: MarkType.X);
        }
        [TestMethod]
        public void IsBoardFull_Should_Return_True_If_Board_Is_Full()
        {
            Board board = new Board();
            for(int i = 0; i < board.Cells.Length; i++)
            {
                board.MarkCell(cellPosition: i, mark: MarkType.X);
            }
            Assert.IsTrue(board.IsBoardFull());
        }
        [TestMethod]
        public void IsBoardFull_Should_Return_False_If_Board_Is_Not_Full()
        {
            Board board = new Board();
            for (int i = 0; i < board.Cells.Length - 1; i++)
            {
                board.MarkCell(cellPosition: i, mark: MarkType.X);
            }
            Assert.IsFalse(board.IsBoardFull());
        }
    }
}
