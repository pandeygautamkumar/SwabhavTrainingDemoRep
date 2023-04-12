using System;
using System.Runtime.CompilerServices;

namespace ObjectCalesthenicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turn = 1;
            int totalScore = 0;
            Console.WriteLine("Let's Play PIG!\r\n\r\n* See how many turns it takes you to get to 20.\r\n* Turn ends when you hold or roll a 1.\r\n* If you roll a 1, you lose all points for the turn.\r\n* If you hold, you save all points for the turn.");
            while (true)
            {
                if (NextTurn(ref turn, ref totalScore)==false) break;
            }   
        }
       
        private static bool NextTurn(ref int turn,ref int totalScore)
        {
            int turnScore = 0;
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("TURN {0}: \n", turn);
            Console.WriteLine("Welcome to the game of Pig!\n");
            while (true)
            {
                if (CurrentMove(ref turnScore, ref totalScore) == false) break;
            }
            turn++;
            if (totalScore >= 20)
            {
                Console.WriteLine("Your Turn score is {0} and your total score is {1}", turnScore, totalScore);
                Console.WriteLine("You Win! You finished in {0} turns!", turn);
                Console.WriteLine("Game Over");
                return false;
            }
            return true;
        }
        
        private static bool CurrentMove(ref int turnScore,ref int totalScore)
        {
            int currentPoint = RollDice();
            if (currentPoint >= 2 && currentPoint <= 6)
            {
                Console.WriteLine("Enter 'r' for Roll Again, 'h' to Hold.");
                string playerChoice = Console.ReadLine();
                if (playerChoice == "r")
                {
                    turnScore += currentPoint;
                    Console.WriteLine("You rolled : " + currentPoint);
                    Console.WriteLine("Your Turn score is {0} and your total score is {1}", turnScore, totalScore);
                    Console.WriteLine("If you hold, you will have {0} points.", turnScore + totalScore);
                    return true;
                }
                totalScore += turnScore;
                Console.WriteLine("Your Turn score is {0} and your total score is {1}", turnScore, totalScore);
                return false;
            }
            Console.WriteLine("You rolled : " + currentPoint);
            Console.WriteLine("Turn Over. No Score");
            return false;
        }
        private static string AskRollOrHold()
        {
            Console.WriteLine("Enter 'r' for Roll Again, 'h' to Hold.");
            string playerChoice = Console.ReadLine();
            return playerChoice;
        }
        private static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
