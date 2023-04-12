using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRaceApp.Model;

namespace VehicleRaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables = new IMovable[5];
            movables[0] = new Car("Audi");
            movables[1] = new Bike("Pulser");
            movables[2] = new Car("BMW");
            movables[3] = new Truck("Ashok Lyland");
            movables[4] = new Bike("Honda");
            StartRace(movables);
        }
        public static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("Starting the Race : ");
            foreach(IMovable movedcar in movables)
            {
                movedcar.Move();
            }
            Console.WriteLine("Race End");
        }
    }
}
