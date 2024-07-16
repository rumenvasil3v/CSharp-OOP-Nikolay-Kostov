namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
Pizza Meatless
Dough Wholegrain Crispy 100
Topping Veggies 50
Topping Cheese 50
END

             */
            try
            {
                string pizzaInformation = Console.ReadLine();
                string[] pizzaArguments = pizzaInformation.Split(' ');
                string pizzaName = pizzaArguments[1];

                Pizza pizza = new(pizzaName);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] commandArguments = command.Split(' ');
                    string ingredient = commandArguments[0];

                    switch (ingredient)
                    {
                        case "Dough":
                            string doughFlourType = commandArguments[1];
                            string doughBakingTechnique = commandArguments[2];
                            int doughWeight = int.Parse(commandArguments[3]);

                            Dough dough = new(doughFlourType, doughBakingTechnique, doughWeight);
                            pizza.Dough = dough;
                            break;
                        case "Topping":
                            string type = commandArguments[1];
                            int weight = int.Parse(commandArguments[2]);

                            Topping topping = new Topping(type, weight);
                            pizza.AddTopping(topping);
                            break;
                    }

                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}