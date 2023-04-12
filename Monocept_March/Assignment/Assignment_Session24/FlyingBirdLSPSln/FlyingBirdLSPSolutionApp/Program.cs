using FlyingBirdLSPSolutionApp.Model;

namespace FlyingBirdLSPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBird ibird = new Parrot();
            PrintBirdDetails(ibird);

            ibird = new Pigeon();
            PrintBirdDetails(ibird);

            ibird = new Ostritch();
            PrintBirdDetails(ibird);
        }
        private static void PrintBirdDetails(IBird ibird)
        {
            Console.WriteLine(ibird.Fly());
        }
    }
}