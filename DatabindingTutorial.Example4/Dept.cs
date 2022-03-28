using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingTutorial.Example4
{
    internal class Dept
    {
        private static int lastID = 0;

        public int ID { get; set; }
        public string Name { get; set; }

        public string Loc { get; set; }


        public List<Emp> Emps { get; set; }

        public Dept()
        {
            this.ID = lastID++;
            Emps = new List<Emp>();

        }

        public Dept(string pName, string pLoc)
        {
            this.ID = lastID++;
            this.Name = pName;
            this.Loc = pLoc;
            this.Emps = new List<Emp>();

        }
    }
}
