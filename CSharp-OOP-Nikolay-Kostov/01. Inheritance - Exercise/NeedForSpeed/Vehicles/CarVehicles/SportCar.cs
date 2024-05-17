using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Vehicles.CarVehicles
{
    public class SportCar : Car
    {
        const double DefaultSportCarFuelConsumption = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption => DefaultSportCarFuelConsumption;
    }
}