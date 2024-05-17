﻿namespace NeedForSpeed.Vehicles
{
    public class Vehicle
    {
        const double DefaultFuelConsumption = 1.25;

        private int horsePower;
        private double fuel;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get { return horsePower; } set { horsePower = value; } }

        public double Fuel { get {  return fuel; } set {  fuel = value; } }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers)
        {
            double fuelNeed = FuelConsumption * kilometers;

            if (Fuel - fuelNeed >= 0)
            {
                Fuel -= fuelNeed;
                return;
            }
        }
    }
}