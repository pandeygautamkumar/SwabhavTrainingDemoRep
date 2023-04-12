using System;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numberOfTrie = 0;
                while (true)
                {
                    numberOfTrie++;
                    Random random = new Random();
                    int computerChoice = random.Next(1, 101);
                    Console.Write("Please Enter Number Between 1 to 100 : ");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    if (userChoice <= 100)
                    {
                        if (userChoice < computerChoice)
                        {
                            Console.WriteLine("Sorry,Too Low.");
                        }
                        else if (userChoice > computerChoice)
                        {
                            Console.WriteLine("Sorry,Too High.");
                        }
                        else if (userChoice == computerChoice)
                        {
                            Console.WriteLine("Total Number of Tries Will be : " + numberOfTrie);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid Number.");
                        Console.WriteLine("|--------------------------------------------------------------------------|");
                        break;
                    }
                    Console.WriteLine("User Choice : " + userChoice);
                    Console.WriteLine("Computer Choice : " + computerChoice);
                    Console.WriteLine("|--------------------------------------------------------------------------|");
                }
                Console.Write("Please Enter Your Choice if Play Again (Yes) or for Not Playing (No) : ");
                string choice = Console.ReadLine();
                if (choice == "No")
                {
                    break;
                }
            }
        }
    }
}
