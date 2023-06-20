
namespace TicTacToeLib.Model
{
    public class Game
    {
        private Board _board;
        private ResultAnalyzer _resultAnalyzer;
        private Player[] _players;
        private Player _currentPlayer;
        private ResultType _status;
        public Game(Board board, ResultAnalyzer resultAnalyzer, Player[] players)
        {
            _board = board;
            _resultAnalyzer = resultAnalyzer;
            _players = players;
            _currentPlayer = players[0];
            _status = ResultType.NO_RESULT;
        }
        public void Play(int cellPosition)
        {
            _board.MarkCell(cellPosition, _currentPlayer.Mark);
            _status = _resultAnalyzer.Analyse();
            if (_currentPlayer == _players[0])
            {
                _currentPlayer = _players[1];
            }
            else
            {
                _currentPlayer = _players[0];
            }
        }
        public ResultType Status { get { return _status; } }
        public Player CurrentPlayer { get { return _currentPlayer; } }
    }
}
