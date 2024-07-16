using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Product
    {
        const string EmptyNameExceptionMessage = "Name cannot be empty";
        const string NegativeMoneyExceptionMessage = "Money cannot be negative";
        const int MinValue = 0;

        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get 
            { 
                return name; 
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(EmptyNameExceptionMessage);
                }

                name = value;
            }
        }

        public decimal Cost
        {
            get 
            { 
                return cost; 
            }

            private set
            {
                if (value < MinValue)
                {
                    throw new ArgumentException(NegativeMoneyExceptionMessage);
                }

                cost = value;
            }
        }

        public override string ToString()
        {
            string productInformation = this.Name;

            return productInformation;
        }
    }
}
