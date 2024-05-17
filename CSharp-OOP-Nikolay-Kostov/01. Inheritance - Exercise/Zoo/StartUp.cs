using System;
using Zoo.Animals;
using Zoo.Animals.MammalChildren;
using Zoo.Animals.ReptileChildren;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            var animal = new Animal(name);
            var mammal = new Mammal(name);
            var bear = new Bear(name);

            var reptile = new Reptile(name);
            var snake = new Snake(name);
        }
    }
}