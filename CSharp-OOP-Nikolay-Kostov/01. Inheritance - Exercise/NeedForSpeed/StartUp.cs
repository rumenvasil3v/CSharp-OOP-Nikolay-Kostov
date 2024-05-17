using System;
using NeedForSpeed.Vehicles;
using NeedForSpeed.Vehicles.CarVehicles;
using NeedForSpeed.Vehicles.MotorcycleVehicles;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.Write("Horse Power: ");
            int horsePower = int.Parse(Console.ReadLine());

            Console.Write("Fuel: ");
            double fuel = double.Parse(Console.ReadLine());

            Console.Write("Kilometers: ");
            double kilometers = double.Parse(Console.ReadLine()); 

            // Create A Vehicle
            Vehicle vehicle = new(horsePower, fuel);
            vehicle.Drive(kilometers);

            // Create a Car
            var car = new Car(horsePower, fuel);
            car.Drive(kilometers); // expected -> fuel = fuel -  kilometers * fuelConsumption;

            var sportCar = new SportCar(horsePower, fuel);
            sportCar.Drive(kilometers);

            // Create a Motorcycle
            var motorcycle = new Motorcycle(horsePower, fuel);
            motorcycle.Drive(kilometers);

            var raceMotorcycle = new RaceMotorcycle(horsePower, fuel);
            raceMotorcycle.Drive(kilometers);
        }
    }
}