using Tic_Tac_Toe_GameApp.Model;

namespace Tic_Tac_Toe_GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char winner = ' ';
            Tic_Tac_Toe ticTactoe = new Tic_Tac_Toe();

            ticTactoe.ResetBoard();
            while (winner == ' ' && ticTactoe.CheckFreeSpace() != 0)
            {
                ticTactoe.PrintBoard();

                ticTactoe.Player1Move();
                winner = ticTactoe.CheckWinner();
                if (winner != ' ' || ticTactoe.CheckFreeSpace() == 0)
                {
                    break;
                }

                ticTactoe.PrintBoard();

                ticTactoe.Player2Move();
                winner = ticTactoe.CheckWinner();
                if (winner != ' ' || ticTactoe.CheckFreeSpace() == 0)
                {
                    break;
                }
                
            }
            ticTactoe.PrintBoard();
            ticTactoe.PrintWinner(winner);
        }
    }
}