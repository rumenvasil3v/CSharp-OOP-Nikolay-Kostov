using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _03.ShoppingSpree
{
    public class Person
    {
        const string EmptyNameExceptionMessage = "Name cannot be empty";
        const string NegativeMoneyExceptionMessage = "Money cannot be negative";
        const string NotEnoughMoneyExceptionMessage = "{0} can't afford {1}";
        const string BoughtProductMessage = "{0} bought {1}";
        const int MinValue = 0;

        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
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

        public decimal Money
        {
            get
            {
                return money;
            }

            private set
            {
                if (value < MinValue)
                {
                    throw new ArgumentException(NegativeMoneyExceptionMessage);
                }

                money = value;
            }
        }

        public IReadOnlyCollection<Product> Products
        {
            get
            {
                return products.AsReadOnly();
            }
        }

        public void BuyProduct(Product product)
        {
            if (CheckEnoughMoney(product.Cost))
            {
                products.Add(product);
                this.Money = this.Money - product.Cost;
                Console.WriteLine(string.Format(BoughtProductMessage, this.Name, product.Name));
            }
            else
            {
                throw new InvalidOperationException(string.Format(NotEnoughMoneyExceptionMessage, this.Name, product.Name));
            }
        }

        public override string ToString()
        {
            string productText = Products.Count > 0 ? $"{string.Join(", ", Products)}" : "Nothing bought";

            StringBuilder sb = new();
            sb.Append($"{this.Name} - {productText}");

            return sb.ToString();
        }

        private bool CheckEnoughMoney(decimal productPrice)
        {
            bool areThereEnoughMoney = Money >= productPrice;

            return areThereEnoughMoney;
        }
    }
}
