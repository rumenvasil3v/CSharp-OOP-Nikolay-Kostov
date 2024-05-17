using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    public class Vehicle
    {
        protected int transmission = 0;
        private int maxTransmission = 6;

        public Vehicle()
        {

        }

        public Vehicle(int maxTransmission)
        {
            Console.WriteLine("Vehicle(int maxTransmission) executed first!");
            this.MaxTransmission = maxTransmission;
        }

        public int MaxTransmission { get => this.maxTransmission; protected set => this.maxTransmission = value; }

        // The base class allows to his children override or change the behaviour of Move() method
        public virtual void Move()
        {
            Console.WriteLine("Vehicle is in motion...");
        }

        public void UpTransmission()
        {
            transmission++;

            if (transmission > maxTransmission)
            {
                transmission = maxTransmission;
            }
        }

        public void DownTransmission()
        {
            transmission--;

            if (transmission < 0)
            {
                transmission = 0;
            }
        }
    }
}