using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals.CatClasses
{
    public class Tomcat : Cat
    {
        const string TomcatGender = "Male";

        public Tomcat(string name, int age)
            : base(name, age, TomcatGender)
        {

        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}