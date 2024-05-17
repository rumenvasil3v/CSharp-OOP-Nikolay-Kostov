namespace Inheritance_Demo
{
    public class Motorbike : Vehicle
    {
        // Motorbike changed behaviour of Move() method to Console.WriteLine("One of the tires got damaged!");
        public override void Move()
        {
            Console.WriteLine("One of the tires got damaged!");
        }
    }
}