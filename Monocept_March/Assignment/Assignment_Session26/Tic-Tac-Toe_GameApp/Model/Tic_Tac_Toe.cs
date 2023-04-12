
using System.Data.Common;

namespace Tic_Tac_Toe_GameApp.Model
{
    internal class Tic_Tac_Toe
    {
        private char[,] board;
        private const char PLAYER1 = 'X';
        private const char PLAYER2 = 'O';
        private const int MAX_ROW = 3;
        private const int MAX_COLUMN = 3;
        public Tic_Tac_Toe()
        {
            board = new char[MAX_ROW, MAX_COLUMN];
        }
        public void ResetBoard()
        {
            for (int i = 0; i < MAX_ROW; i++)
            {
                for (int j = 0; j < MAX_COLUMN; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }
        public void PrintBoard()
        {
            Console.WriteLine($"{board[0, 0]} │ {board[0, 1]} │ {board[0, 2]}");
            Console.WriteLine("--│---│--");
            Console.WriteLine($"{board[1, 0]} │ {board[1, 1]} │ {board[1, 2]}");
            Console.WriteLine("--│---│--");
            Console.WriteLine($"{board[2, 0]} │ {board[2, 1]} │ {board[2, 2]}");
            Console.WriteLine("--│---│--");
        }
        public int CheckFreeSpace()
        {
            int freeSpace = 9;
            for (int i = 0; i < MAX_ROW; i++)
            {
                for (int j = 0; j < MAX_COLUMN; j++)
                {
                    if (board[i, j] != ' ')
                    {
                        freeSpace--;
                    }
                }
            }
            return freeSpace;
        }
        public void Player1Move()
        {
            int x;
            int y;
            Console.WriteLine("Player1 Move:");
            do
            {
                DisplayMenu(out x, out y);
                if (board[x, y] != ' ')
                {
                    Console.WriteLine("Invalid Move.");
                }
                else
                {
                    board[x, y] = PLAYER1;
                    break;
                }
            }
            while (board[x, y] != ' ');
        }
        public void Player2Move()
        {
            int x;
            int y;
            Console.WriteLine("Player2 Move:");
            do
            {
                DisplayMenu(out x, out y);
                if (board[x, y] != ' ')
                {
                    Console.WriteLine("Invalid Move.");
                }
                else
                {
                    board[x, y] = PLAYER2;
                    break;
                }
            }
            while (board[x, y] != ' ');
        }

        private static void DisplayMenu(out int x, out int y)
        {
            Console.Write("Enter Row #(1,3) : ");
            x = Convert.ToInt32(Console.ReadLine());
            x--;
            Console.Write("Enter Column #(1,3) : ");
            y = Convert.ToInt32(Console.ReadLine());
            y--;
            Console.WriteLine();
        }

        public char CheckWinner()
        {
            // Check Rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                {
                    return board[i, 0];
                }
            }
            // Check Column
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[0, i] == board[2, i])
                {
                    return board[0, i];
                }
            }
            // Check Diagonal
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                return board[0, 0];
            }
            if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                return board[0, 2];
            }
            return ' ';
        }

        public void PrintWinner(char winner)
        {
            if (winner == PLAYER1)
            {
                Console.WriteLine("Player 1 (X) Win.");
            }
            else if (winner == PLAYER2)
            {
                Console.WriteLine("Player 2 (O) Win.");
            }
            else
            {
                Console.WriteLine("Its, Draw");
            }
        }
    }
}
