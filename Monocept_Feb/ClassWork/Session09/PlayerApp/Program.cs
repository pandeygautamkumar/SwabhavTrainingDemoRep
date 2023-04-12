using PlayerApp.Model;
using System;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            DemoStudy3();
        }

        private static void DemoStudy3()
        {
            Player sachin = new Player(1, "Sachin", 56);
            Player[] manyPlayer = new Player[5];
            manyPlayer[0] = new Player(1, "Player 1", 20);
            manyPlayer[1] = sachin;
            manyPlayer[2] = sachin;
            manyPlayer[3] = sachin;
            manyPlayer[4] = sachin;

            foreach (Player player in manyPlayer)
            {
                PrintDetails(player);
            }
        }

        private static void CaseStudy1()
        {
            Player playerA = new Player(1, "Sachin", 54);
            Player playerB = new Player(2, "Virat");
            PrintDetails(playerA, "Player A Details.");
            PrintDetails(playerB, "Player B Details.");
        }

        private static void CaseStudy2()
        {
            Player sachin = new Player(1, "Sachin", 54);
            Player virat = new Player(2, "Virat");
            // Player elder=virat.WhoIsElder(sachin);
            Player elder = sachin.WhoIsElder(virat);
            //PrintDetails(elder, "Elder Object");

            Console.WriteLine("Sachin HasCode : " + sachin.GetHashCode());
            Console.WriteLine("Virat HashCode : " + virat.GetHashCode());
            Console.WriteLine("Elder hashCode : " + elder.GetHashCode());
        }

        static void PrintDetails(Player player,string description="")
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Id is : "+player.Id);
            Console.WriteLine("Name is : "+player.Name);
            Console.WriteLine("Age is : "+player.Age);
        }
    }
}
