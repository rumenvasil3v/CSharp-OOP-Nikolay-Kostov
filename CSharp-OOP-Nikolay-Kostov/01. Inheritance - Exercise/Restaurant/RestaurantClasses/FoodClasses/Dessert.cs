using Restaurant.RestaurantClasses;

namespace Restaurant.RestaurantClasses.FoodClasses
{
    public class Dessert : Food
    {
        private double calories;

        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }

        public double Calories { get { return calories; } set { calories = value; } }
    }
}