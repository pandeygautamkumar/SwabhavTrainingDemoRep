using FlyingBirdLSPViolationApp.Model;

namespace FlyingBirdLSPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBirdDetails(new Bird());
            PrintBirdDetails(new Pigeon());
            PrintBirdDetails(new Parrot());
            PrintBirdDetails(new Ostritch());
        }
        private static void PrintBirdDetails(Bird bird)
        {
            Console.WriteLine(bird.Fly());
        }
    }
}