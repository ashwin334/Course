using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class COURSE
    {
        private int id;
        private string name;
        double fees;

        public void add(int id, string name, double fees)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
        }
        public string Print()
        {
            return $" Course:{id}/{name}/{fees}";
        }
    }
}
