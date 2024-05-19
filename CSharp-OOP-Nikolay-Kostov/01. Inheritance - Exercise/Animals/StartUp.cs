using Animals.Animals;
using Animals.Animals.CatClasses;
using System;
using System.Collections.Generic;
using System.Linq;

/*
Tomcat
Tom -12 Male
Kitten
Kit 234 Male
Beast!

 */


namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string endCommand = "Beast!";

            string animalType = Console.ReadLine();
            string[] animalInformation = Console
                .ReadLine()
                .Split(" ");

            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string animalName = animalInformation[0];
                int animalAge = int.Parse(animalInformation[1]);
                string animalGender = animalInformation[2];

                try
                {
                    Animal animal = CreateAnAnimal(animalType, animalName, animalAge, animalGender);
                    animals.Add(animal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animalType = Console.ReadLine();

                if (animalType == endCommand)
                {
                    break;
                }

                 animalInformation = Console
                    .ReadLine()
                    .Split(" ");
            }

            PrintAnimals(animals);
        }

        public static Animal CreateAnAnimal(string animalType, string name, int age, string gender)
        {
            Animal animal = null;

            switch (animalType)
            {
                case "Cat":
                    animal = new Cat(name, age, gender);
                    return animal;
                case "Dog":
                    animal = new Dog(name, age, gender);
                    return animal;
                case "Frog":
                    animal = new Frog(name, age, gender);
                    return animal;
                case "Kitten":
                    animal = new Kitten(name, age);
                    return animal;
                case "Tomcat":
                    animal = new Tomcat(name, age);
                    return animal;
                default:
                    throw new ArgumentException("This type of Animal doesn't exist. Consider the library!");
            }
        }

        public static void PrintAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}