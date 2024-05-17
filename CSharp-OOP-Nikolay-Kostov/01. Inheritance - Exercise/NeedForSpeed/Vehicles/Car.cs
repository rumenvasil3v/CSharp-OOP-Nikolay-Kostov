using System;

namespace NeedForSpeed.Vehicles
{
    public class Car : Vehicle
    {
        const double DefaultCarFuelConsumption = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultCarFuelConsumption;
    }
}