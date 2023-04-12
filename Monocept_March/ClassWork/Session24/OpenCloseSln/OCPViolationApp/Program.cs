using OCPViolationApp.Model;

namespace OCPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Anikant", 100000, 1, FestivalTypes.DIWALI);
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}