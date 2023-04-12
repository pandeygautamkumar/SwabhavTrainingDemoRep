using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableReefectoredApp.Model
{
    internal abstract class Vehicle : IMovable
    {
        private string _name;
        public Vehicle (string name)
        {
            _name = name;
        }
        public string Name { get { return _name; } }
        public abstract void Move();
    }
}
