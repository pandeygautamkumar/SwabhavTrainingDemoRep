
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void Analyse_Should_Result_No_Result_For_Empty_Board()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyse();
            Assert.IsTrue(result == ResultType.NO_RESULT);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Vertically_Same_Cell_With_X_Column_1()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[3].Mark = MarkType.X;
            board.Cells[6].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Vertically_Same_Cell_With_O_Column_1()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.O;
            board.Cells[3].Mark = MarkType.O;
            board.Cells[6].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Vertically_Same_Cell_With_X_For_Column_2()
        {
            Board board = new Board();
            board.Cells[1].Mark = MarkType.X;
            board.Cells[4].Mark = MarkType.X;
            board.Cells[7].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Vertically_Same_Cell_With_O_Column_2()
        {
            Board board = new Board();
            board.Cells[1].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[7].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Vertically_Same_Cell_With_X_For_Column_3()
        {
            Board board = new Board();
            board.Cells[2].Mark = MarkType.X;
            board.Cells[5].Mark = MarkType.X;
            board.Cells[8].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Vertically_Same_Cell_With_O_Column_3()
        {
            Board board = new Board();
            board.Cells[2].Mark = MarkType.O;
            board.Cells[5].Mark = MarkType.O;
            board.Cells[8].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }

        public void Analyse_Should_Return_Win_For_Horizontally_Same_Cell_With_X_Column_1()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[1].Mark = MarkType.X;
            board.Cells[2].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Horizontally_Same_Cell_With_O_Column_1()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.O;
            board.Cells[1].Mark = MarkType.O;
            board.Cells[2].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Horizontally_Same_Cell_With_X_For_Column_2()
        {
            Board board = new Board();
            board.Cells[3].Mark = MarkType.X;
            board.Cells[4].Mark = MarkType.X;
            board.Cells[5].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Horizontally_Same_Cell_With_O_Column_2()
        {
            Board board = new Board();
            board.Cells[3].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[5].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Horizontally_Same_Cell_With_X_For_Column_3()
        {
            Board board = new Board();
            board.Cells[6].Mark = MarkType.X;
            board.Cells[7].Mark = MarkType.X;
            board.Cells[8].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Horizontally_Same_Cell_With_O_Column_3()
        {
            Board board = new Board();
            board.Cells[6].Mark = MarkType.O;
            board.Cells[7].Mark = MarkType.O;
            board.Cells[8].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }

        public void Analyse_Should_Return_Win_For_Diagonally_Same_Cell_With_X_Diagonal_1()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[4].Mark = MarkType.X;
            board.Cells[8].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Diagonally_Same_Cell_With_O_Diagonal_1()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[8].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Diagonally_Same_Cell_With_X_For_Diagonal_2()
        {
            Board board = new Board();
            board.Cells[2].Mark = MarkType.X;
            board.Cells[4].Mark = MarkType.X;
            board.Cells[6].Mark = MarkType.X;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_Should_Return_Win_For_Diagonally_Same_Cell_With_O_Diagonal_2()
        {
            Board board = new Board();
            board.Cells[2].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[6].Mark = MarkType.O;
            ResultAnalyzer resultAnalyser = new ResultAnalyzer(board);
            ResultType result = resultAnalyser.Analyse();
            Assert.IsTrue(result == ResultType.WIN);
        }
        [TestMethod]
        public void Analyse_No_Result_Case()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[1].Mark = MarkType.X;
            board.Cells[2].Mark = MarkType.O;

            board.Cells[3].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[5].Mark = MarkType.X;

            board.Cells[6].Mark = MarkType.X;
            board.Cells[7].Mark = MarkType.X;
            //board.Cells[8].Mark = MarkType.O;

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyse();
            Assert.IsTrue(result == ResultType.NO_RESULT);
        }
        [TestMethod]
        public void Analyse_Draw_Case()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[1].Mark = MarkType.X;
            board.Cells[2].Mark = MarkType.O;

            board.Cells[3].Mark = MarkType.O;
            board.Cells[4].Mark = MarkType.O;
            board.Cells[5].Mark = MarkType.X;

            board.Cells[6].Mark = MarkType.X;
            board.Cells[7].Mark = MarkType.X;
            board.Cells[8].Mark = MarkType.O;

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyse();
            Assert.IsTrue(result == ResultType.DRAW);
        }
    }
}
