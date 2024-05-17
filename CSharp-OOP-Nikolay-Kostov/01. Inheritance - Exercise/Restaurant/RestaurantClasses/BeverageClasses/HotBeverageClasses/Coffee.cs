using Restaurant.RestaurantClasses.BeverageClasses;

namespace Restaurant.RestaurantClasses.BeverageClasses.HotBeverageClasses
{
    public class Coffee : HotBeverage
    {
        const double CoffeeMilliliters = 50;
        const decimal CoffeePrice = 3.50m;

        private double caffeine;

        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get { return caffeine; } set { caffeine = value; } }
    }
}