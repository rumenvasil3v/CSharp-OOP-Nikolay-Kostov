using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    public class Truck : Vehicle
    {
        private int maxCapacity = 6;
        private Stack<string> products;

        void Load(string product)
        {
            if (product.Length < maxCapacity)
            {
                products.Push(product);
            }
        }

        string Unload()
        {
            if (products.Count > 0)
            {
                return products.Pop();
            }

            return null;
        }

        // Truck changed behaviour of Move() method to Console.WriteLine("All 16 tires work...");
        public override void Move()
        {
            Console.WriteLine("All 16 tires work...");
        }
    }
}