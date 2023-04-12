using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintName("Gautam", 10);
            bool result = CheckEven1(12);
            Console.WriteLine(result);

            PrintTodaysDate();

            string[] developerNames = GetDeveloperNames();
            foreach(string name in developerNames)
            {
                Console.WriteLine(name.ToUpper());
            }
            /*
            Console.Write("Enter Your Name : ");
            string userName = Console.ReadLine();
            Console.WriteLine("WelCome Back : " + userName.ToUpper());
            */

            RollDice(6);

        }
        static bool CheckEven(int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }
        static bool CheckEven1(int number)
        {
            if (number % 2 == 0) return true;
            return false;
        }
        static void PrintTodaysDate()
        {
            Console.WriteLine(DateTime.Now.ToString("M"));
        }
        static string[] GetDeveloperNames()
        {
            String[] names = { "Aiswarya", "Ravi", "Gautam", "Manjunath", "Vikrant" };
            return names;
        }
        static void PrintName(String userName,int iterations)
        {
            for(int i = 0; i < iterations; i++)
            {
                Console.WriteLine(userName.ToUpper());
            }
        }
        static void RollDice(int rollCount)
        {
            Random random = new Random();
            for(int i = 0; i < rollCount; i++)
            {
                Console.WriteLine("Number Will be : "+random.Next(1, 7));
            }
        }
    }
}
