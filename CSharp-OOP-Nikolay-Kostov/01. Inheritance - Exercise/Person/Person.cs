using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        //1. Add fields
        private string name;
        private int age;

        //2. Add constructor
        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //3. Add Properties
        public string Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } set { age = value; } }

        //4. Add Methods
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append($"Name: {Name}, Age: {Age}");

            string resultString = sb.ToString();

            return resultString;
        }
    }
}
