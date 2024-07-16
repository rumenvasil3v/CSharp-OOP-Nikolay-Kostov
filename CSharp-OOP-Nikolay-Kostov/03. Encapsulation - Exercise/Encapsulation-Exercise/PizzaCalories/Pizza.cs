namespace _04.PizzaCalories
{
    public class Pizza
    {
        // Max symbols name
        private const double MaxSymbols = 15;
        private const double MinSymbols = 1;

        // Min and Max number of toppings
        private const double MaxNumberToppings = 10;
        private const double MinNumberToppings = 0;

        // Exception Messages
        private const string InvalidNameExceptionMessage = "Pizza name should be between {0} and {1} symbols.";
        private const string OutOfRangeNumberOfToppings = "Number of toppings should be in range [{0}..{1}].";

        private string name;
        private List<Topping> toppings;
        private Dough dough;
        private int numberOfToppings;

        public Pizza(string name)
        {
            toppings = new List<Topping>();
            Name = name;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception(string.Format(InvalidNameExceptionMessage, MinSymbols, MaxSymbols));
                }

                if (value.Length > MaxSymbols)
                {
                    throw new Exception(string.Format(InvalidNameExceptionMessage, MinSymbols, MaxSymbols));
                }

                name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set
            {
                this.dough = value;
            }
        }

        public int NumberOfToppings
        {
            get { return numberOfToppings; }
            private set
            {
                if (value < MinNumberToppings || value > MaxNumberToppings)
                {
                    throw new Exception(string.Format(OutOfRangeNumberOfToppings, MinNumberToppings, MaxNumberToppings));
                }

                numberOfToppings = value;
            }
        }

        public double TotalCalories => CalculateTotalCalories();

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
            NumberOfToppings++;
        }

        public override string ToString()
        {
            string pizzaText = $"{Name} - {TotalCalories:f2} Calories.";
            return pizzaText;
        }

        private double CalculateTotalCalories()
        {
            double totalCalories = 0;
            totalCalories += dough.TotalCalories;

            foreach (var topping in toppings)
            {
                totalCalories += topping.TotalCalories;
            }

            return totalCalories;
        }
    }
}
