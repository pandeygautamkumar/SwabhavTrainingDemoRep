using MovableReefectoredApp.Model;

namespace MovableReefectoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables ={
                new Car("Honda"),
                new Car("BMW"),
                new Bike("Bajaj")
            };
            StartRace(movables);
        }
        static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("Race Start");
            foreach(IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}