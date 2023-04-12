using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib.Model
{
    [Serializable]
    public class Customer
    {
        private int _id;
        private string _name;
        public Customer(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public int Id
        {
            get { return _id; }
            set {  _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
