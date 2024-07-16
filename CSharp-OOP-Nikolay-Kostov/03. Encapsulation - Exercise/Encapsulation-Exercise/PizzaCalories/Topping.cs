namespace _04.PizzaCalories
{
    public class Topping
    {
        // Type Modifiers
        private const double MeatModifier = 1.2;
        private const double VeggiesModifier = 0.8;
        private const double CheeseModifier = 1.1;
        private const double SauceModifier = 0.9;
        private const double BaseCaloriesPerGram = 2;

        // Exception Messages
        private const string InvalidTypeExceptionMessage = "Cannot place {0} on top of your pizza.";
        private const string OutOfRangeToppingWeightExceptionMessage = "{0} weight should be in the range [{1}..{2}].";

        // Min and Max weight of Topping
        private const int MinValue = 1;
        private const int MaxValue = 50;

        private Dictionary<string, double> types;

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            types = new Dictionary<string, double>()
            {
                { "meat", MeatModifier },
                { "veggies", VeggiesModifier },
                { "cheese", CheeseModifier },
                { "sauce", SauceModifier },
            };
            Type = type;
            Weight = weight;
        }

        private string Type
        {
            get { return type; }
            set
            {
                ValidateType(value.ToLower());

                type = value;
            }
        }

        private int Weight
        {
            get { return this.weight; }
            set
            {
                ValidateWeight(value);

                this.weight = value;
            }
        }

        public double CaloriesPerGram => CalculateCaloriesPerGram();

        public double TotalCalories => CalculateTotalCalories();

        private double CalculateTotalCalories()
        {
            double typeModifier = types[Type.ToLower()];
            double totalCalories = BaseCaloriesPerGram * Weight * typeModifier;

            return totalCalories;
        }

        private double CalculateCaloriesPerGram()
        {
            double typeModifier = types[Type.ToLower()];
            double caloriesPerGram = BaseCaloriesPerGram * typeModifier;

            return caloriesPerGram;
        }

        private void ValidateType(string value)
        {
            if (!types.ContainsKey(value))
            {
                value = value[0].ToString().ToUpper() + value.Substring(1);
                throw new Exception(string.Format(InvalidTypeExceptionMessage, value));
            }
        }

        private void ValidateWeight(int value)
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new Exception(string.Format(OutOfRangeToppingWeightExceptionMessage, Type, MinValue, MaxValue));
            }
        }
    }
}
