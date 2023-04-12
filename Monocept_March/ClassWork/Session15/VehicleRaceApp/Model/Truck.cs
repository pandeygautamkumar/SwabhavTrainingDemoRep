using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRaceApp.Model
{
    internal class Truck : IMovable
    {
        private string _name;
        public Truck(string name)
        {
            _name = name;
        }
        public void Move()
        {
            Console.WriteLine(_name + " is Moving.");
        }
    }
}
