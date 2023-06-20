
using System;
using System.Windows.Forms;
using TicTacToeLib.Model;
using System.Windows.Forms;

namespace TicTacToeUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleUI();
            //Application.Run(new SimpleForm());
            Application.Run(new TicTacToeWindowFormUi());
        }

        private static void ConsoleUI()
        {
            while (true)
            {
                Player p1 = new Player { Mark = MarkType.X, Name = "Player_1" };
                Player p2 = new Player { Mark = MarkType.O, Name = "Player_2" };
                Player[] players = { p1, p2 };
                Board board = new Board();
                ResultAnalyzer analyzer = new ResultAnalyzer(board);
                Game game = new Game(board, analyzer, players);

                while (true)
                {
                    MarkType currentPlayerMark = game.CurrentPlayer.Mark;
                    Console.Write("Enter Cell No for Player {0} Between(1-9): ", currentPlayerMark);
                    int cellPosition = Convert.ToInt32(Console.ReadLine());
                    game.Play(cellPosition - 1);
                    PrintBoard(board);
                    if (game.Status == ResultType.DRAW)
                    {
                        break;
                    }
                    if (game.Status == ResultType.WIN)
                    {
                        Console.WriteLine("Player {0} Win this Match.", currentPlayerMark);
                        Console.WriteLine();
                        break;
                    }
                }

                Console.Write("Do You Want to Restart the Game (YES/NO): ");
                string userChoise = Console.ReadLine();
                if (userChoise.ToUpper() == "NO")
                {
                    break;
                }
                Console.WriteLine("----------------------------------------------------------------");
            }
        }

        static void PrintBoard(Board board)
        {
            int cell = 0;
            foreach (Cell c in board.Cells)
            {
                cell++;
                Console.Write(c.Mark + "\t");
                if (cell == 3 || cell == 6)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("=========================");
        }
    }
}
