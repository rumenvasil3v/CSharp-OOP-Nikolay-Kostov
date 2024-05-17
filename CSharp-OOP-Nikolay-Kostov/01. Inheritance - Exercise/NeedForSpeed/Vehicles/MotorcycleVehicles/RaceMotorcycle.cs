using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Vehicles.MotorcycleVehicles
{
    public class RaceMotorcycle : Motorcycle
    {
        const double DefaultRaceMotorcycleFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption => DefaultRaceMotorcycleFuelConsumption;
    }
}