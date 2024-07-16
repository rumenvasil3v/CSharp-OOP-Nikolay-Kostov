namespace _04.PizzaCalories
{
    public class Dough
    {
        // Dough Modifiers => provide the exact calories
        private const double BaseCaloriesPerGram = 2;
        private const double WhiteModifier = 1.5;
        private const double ChewyModifier = 1.1;
        private const double WholegrainModifier = 1.0;
        private const double CrispyModifier = 0.9;
        private const double HomemadeModifier = 1.0;

        // Exception Messages
        private const string InvalidTypeOfDoughExceptionMessage = "Invalid type of dough.";
        private const string OutOfRangeWeghtExceptionMessage = "Dough weight should be in the range [1..200].";

        // Weigh min and max value
        private const int MaxValue = 200;
        private const int MinValue = 1;

        private Dictionary<string, double> flourTypes;
        private Dictionary<string, double> bakingTechniques;

        private string flourType;
        private string bakingTechnique;
        private int weighInGrams;

        public Dough(string flourType, string bakingTechnique, int weightInGrams)
        {
            flourTypes = new Dictionary<string, double>()
            {
                { "white", WhiteModifier },
                { "wholegrain", WholegrainModifier },
            };
            bakingTechniques = new Dictionary<string, double>()
            {
                { "chewy", ChewyModifier },
                { "crispy", CrispyModifier },
                { "homemade", HomemadeModifier },
            };
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.WeightInGrams = weightInGrams;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                ValidateDoughIngredient(flourTypes, value.ToLower());

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                ValidateDoughIngredient(bakingTechniques, value.ToLower());

                bakingTechnique = value;
            }
        }

        public int WeightInGrams
        {
            get { return this.weighInGrams; }
            private set
            {
                ValidateWeight(value);

                this.weighInGrams = value;
            }
        }

        public double CaloriesPerGram => CalculateCaloriesPerGram();

        public double TotalCalories => CalculateTotalCalories();

        private double CalculateCaloriesPerGram()
        {
            double flourTypeModifier = flourTypes[FlourType.ToLower()];
            double bakingTechniqueModifier = bakingTechniques[BakingTechnique.ToLower()];

            double caloriesPerGram = BaseCaloriesPerGram * flourTypeModifier * bakingTechniqueModifier;

            return caloriesPerGram;
        }

        private double CalculateTotalCalories()
        {
            double flourTypeModifier = flourTypes[FlourType.ToLower()];
            double bakingTechniqueModifier = bakingTechniques[BakingTechnique.ToLower()];

            double totalCalories = (BaseCaloriesPerGram * WeightInGrams) * flourTypeModifier * bakingTechniqueModifier;

            return totalCalories;
        }

        private void ValidateDoughIngredient(Dictionary<string, double> collection, string ingredient)
        {
            if (!collection.ContainsKey(ingredient))
            {
                throw new Exception(InvalidTypeOfDoughExceptionMessage);
            }
        }

        private void ValidateWeight(int value)
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new Exception(OutOfRangeWeghtExceptionMessage);
            }
        }
    }
}
