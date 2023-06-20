
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Constructor_When_Game_Is_Created_Current_Player_Should_be_Player_0()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player_1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player_2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            Assert.AreEqual(players[0], game.CurrentPlayer);
        }
        [TestMethod]
        public void Constructor_When_Game_Is_Created_Status_Will_be_No_Result()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player_1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player_2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            Assert.IsTrue(game.Status==ResultType.NO_RESULT);
        }
        [TestMethod]
        public void Play_When_Play_Is_Called_Once_Current_Player_Should_Change()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player_1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player_2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            game.Play(cellPosition: 5);

            Assert.AreEqual(players[1], game.CurrentPlayer);
        }
        [TestMethod]
        public void Play_When_Play_Is_Called_Twice_Current_Player_Should_Change()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player_1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player_2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            game.Play(cellPosition: 5);
            game.Play(cellPosition: 4);
            Assert.AreEqual(players[0], game.CurrentPlayer);
        }
        [TestMethod]
        public void Play_After_Play_Check_Board_Is_Updated()
        {
            Player p1 = new Player { Mark = MarkType.X, Name = "Player_1" };
            Player p2 = new Player { Mark = MarkType.O, Name = "Player_2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            //MarkType currentPlayerMark = game.CurrentPlayer.Mark;
            game.Play(cellPosition: 8);
            //Assert.IsTrue(board.Cells[8].Mark ==currentPlayerMark);
            Assert.IsTrue(board.Cells[8].Mark==MarkType.X);
        }
    }
}
