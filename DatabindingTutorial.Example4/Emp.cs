using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingTutorial.Example4
{
    internal class Emp
    {
        private static int last_ID = 0;

        public int ID { get; set; }
        public string Name { get; set; }

        public string Job { get; set; }
        public decimal Sal { get; set; }


        public Emp()
        {
            ID = last_ID++;
            Name =string.Empty; 
            Job = string.Empty; 
            Sal = 0;
        }

        public Emp(string pName, string pJob, decimal pSal)
        {
            ID=last_ID++;
            this.Name = pName;
            this.Job = pJob;
            this.Sal = pSal;
        }

       
    }
}
