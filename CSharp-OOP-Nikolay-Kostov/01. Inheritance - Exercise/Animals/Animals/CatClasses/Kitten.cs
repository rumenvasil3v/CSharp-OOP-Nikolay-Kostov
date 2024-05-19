using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals.CatClasses
{
    public class Kitten : Cat
    {
        const string KittenGender = "Female";

        public Kitten(string name, int age)
    : base(name, age, KittenGender)
        {

        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}