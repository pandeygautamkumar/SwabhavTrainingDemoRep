using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VehicleRaceApp.Model
{
    internal class Bike : IMovable
    {
        private string _name;
        public Bike(string name)
        {
            _name = name;
        }
        public void Move()
        {
            Console.WriteLine(_name + " is Moving.");
        }
    }
}
