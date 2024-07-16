using System.Diagnostics.Metrics;

namespace _03.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            string people = Console.ReadLine();
            string products = Console.ReadLine();

            RunProgram(people, products);
        }

        private static void RunProgram(string people, string products)
        {
            try
            {
                var peopleCount = people.Split(';', StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, Person> peopleList = GetPeopleInfo(peopleCount);

                var productsCount = products.Split(';', StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, Product> productsList = GetProductList(productsCount);

                BuyProducts(peopleList, productsList);
                PrintPeople(peopleList);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void PrintPeople(Dictionary<string, Person> peopleList)
        {
            foreach (var person in peopleList)
            {
                Console.WriteLine(person.Value);
            }
        }

        private static void BuyProducts(Dictionary<string, Person> peopleList, Dictionary<string, Product> productsList)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArguments = command.Split(' ');

                string personName = commandArguments[0];
                string productName = commandArguments[1];

                if (peopleList.ContainsKey(personName) && productsList.ContainsKey(productName))
                {
                    Person person = peopleList[personName];
                    Product product = productsList[productName];

                    try
                    {
                        person.BuyProduct(product);
                    }
                    catch (InvalidOperationException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

                command = Console.ReadLine();
            }
        }

        private static Dictionary<string, Product> GetProductList(string[] productsCount)
        {
            var productsList = new Dictionary<string, Product>();

            for (int i = 0; i < productsCount.Length; i++)
            {
                string[] productArguments = productsCount[i].Split('=');

                string productName = productArguments[0];
                decimal productCost = decimal.Parse(productArguments[1]);

                Product product = new(productName, productCost);
                AddProduct(productsList, product);
            }

            return productsList;
        }

        private static void AddProduct(Dictionary<string, Product> productsList, Product product)
        {
            productsList.Add(product.Name, product);
        }

        private static Dictionary<string, Person> GetPeopleInfo(string[] peopleCount)
        {
            var peopleList = new Dictionary<string, Person>();

            for (int i = 0; i < peopleCount.Length; i++)
            {
                string[] personArguments = peopleCount[i].Split('=');

                string personName = personArguments[0];
                decimal personMoney = decimal.Parse(personArguments[1]);

                Person person = new(personName, personMoney);
                AddPerson(peopleList, person);
            }

            return peopleList;
        }

        private static void AddPerson(Dictionary<string, Person> people, Person person)
        {
            people.Add(person.Name, person);
        }
    }
}