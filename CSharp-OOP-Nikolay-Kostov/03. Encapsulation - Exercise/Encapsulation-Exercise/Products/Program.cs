using _03.ShoppingSpree;

namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Rumen", 20);
            person.BuyProduct(new Product("Lasagna", 30));
        }
    }
}