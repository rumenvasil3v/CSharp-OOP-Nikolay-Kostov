using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class HighSchoolStudent : Student
    {
        public DateTime Prom { get; set; }

        public void Competing()
        {
            Console.WriteLine("Competing..");
            Console.WriteLine("Competing...");
            Console.WriteLine("Competing....");
            Console.WriteLine("Competing.....");

            Study();

            Console.WriteLine("Competing.....");
            Console.WriteLine("Competing....");
            Console.WriteLine("Competing...");
            Console.WriteLine("Competing..");
        }
    }
}
