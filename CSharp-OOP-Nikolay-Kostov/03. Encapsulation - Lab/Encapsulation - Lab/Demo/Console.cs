using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Car
    {
        public Car()
        {
            
        }

        public string model { get; set; }

        public double HorsePower { get; set; }

        public void StartCar()
        {
            InjectFuelIntoEngine();
        }

        private void InjectFuelIntoEngine()
        {

        }
    }
}
