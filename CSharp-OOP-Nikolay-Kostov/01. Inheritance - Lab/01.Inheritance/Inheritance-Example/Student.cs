using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Student : Person
    {
        private string school;

        public Student()
        {

        }

        public Student(string name, string adress, string school)
            : base(name, adress)
        {
            this.School = school;
        }

        public string School { get { return this.school; } set { this.school = value; } }

        public void Study()
        {
            Console.WriteLine("Studying..");
            Console.WriteLine("Studying...");
            Console.WriteLine("Studying....");
            Console.WriteLine("Studying.....");

            Walk();

            Console.WriteLine("Studying.....");
            Console.WriteLine("Studying....");
            Console.WriteLine("Studying...");
            Console.WriteLine("Studying..");
        }
    }
}