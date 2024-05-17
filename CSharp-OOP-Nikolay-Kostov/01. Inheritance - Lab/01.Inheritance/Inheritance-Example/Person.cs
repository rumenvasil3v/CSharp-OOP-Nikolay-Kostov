using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Person
    {
        private string name;
        private string adress;

        public Person()
        {

        }

        public Person(string name, string adress)
        {
            this.Name = name;
            this.Adress = adress;
        }

        public string Name { get { return this.name; } set {  this.name = value; } }

        public string Adress { get {  return this.adress; } set {  this.adress = value; } }

        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }
}