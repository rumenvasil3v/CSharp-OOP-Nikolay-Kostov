namespace Inheritance_Test
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Gaaa");
        }
    }

    public class  Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
        }
    }

    public class Puppy : Dog
    {
        public override void MakeSound()
        {
            base.MakeSound();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.MakeSound();
        }
    }
}