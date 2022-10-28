using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            COURSE c1 = new COURSE();
            c1.add(83, "Ashwin", 75.8);
            Console.WriteLine(c1.Print());
        }
    }
    
}
