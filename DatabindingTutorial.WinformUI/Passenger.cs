using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingTutorial.WinformUI
{
    class Passenger
    {
        public Passenger(string name)
        {
            _id = ++lastID; Name = name;
        }
        private static int lastID = 0;
        public int _id;
        public int ID { get { return _id; } }
        public string _name;
        public string Name { get { return _name; } set { _name = value; } }
    }
}
