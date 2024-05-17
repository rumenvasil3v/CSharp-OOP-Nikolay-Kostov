namespace Inheritance_Demo
{
    // Base class, Super class, Parent class
    // The only two relationships between classes are Inheritance and Composition
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(6);
            car.Move();
            
            var truck = new Truck();
            truck.Move();

            var motorbike = new Motorbike();
            motorbike.Move();

            var electricCar = new ElectricCar();
            electricCar.Move();
        }
    }
}