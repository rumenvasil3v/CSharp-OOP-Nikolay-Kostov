using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Employee : Person
    {
        private string company;

        public Employee()
        {

        }

        public Employee(string company)
        {
            this.Company = company;
        }

        public string Company { get { return this.company; } set { this.company = value; } }
    }
}