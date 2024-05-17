using Restaurant.RestaurantClasses.FoodClasses;

namespace Restaurant.RestaurantClasses.FoodClasses.DessertClasses
{
    public class Cake : Dessert
    {
        const double DefaultGrams = 250;
        const double DefaultCalories = 1000;
        const decimal DefaultPrice = 5m;

        public Cake(string name)
            : base(name, DefaultPrice, DefaultGrams, DefaultCalories)
        {

        }
    }
}