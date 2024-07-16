namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pizza pizza = CreatePizza();
                Dough dough = CreateDough();
                pizza.Dough = dough;

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] commandArguments = command.Split(' ');
                    string ingredient = commandArguments[0];

                    string type = commandArguments[1];
                    int weight = int.Parse(commandArguments[2]);

                    Topping topping = new Topping(type, weight);
                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static Pizza CreatePizza()
        {
            string pizzaInformation = Console.ReadLine();
            string[] pizzaArguments = pizzaInformation.Split(' ');
            string pizzaName = pizzaArguments[1];

            Pizza pizza = new(pizzaName);
            return pizza;
        }

        private static Dough CreateDough()
        {
            string doughInformation = Console.ReadLine();
            string[] doughArguments = doughInformation.Split(' ');

            string doughFlourType = doughArguments[1];
            string doughBakingTechnique = doughArguments[2];
            int doughWeight = int.Parse(doughArguments[3]);

            Dough dough = new(doughFlourType, doughBakingTechnique, doughWeight);
            return dough;
        }
    }
}