using System;
using System.Text;

namespace Animals.Animals
{
    public abstract class Animal
    {
        const string ExceptionMessage = "Invalid input!";

        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name 
        {
            get => name; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessage);
                }

                name = value; 
            } 
        }
    
        public int Age 
        {
            get => age;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessage);
                }

                age = value; 
            } 
        }
    
        public string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessage);
                }

                gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(this.GetType().Name);

            string template = $"{this.Name} {this.Age} {this.Gender}";
            sb.AppendLine(template);
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().Trim();
        }
    }
}