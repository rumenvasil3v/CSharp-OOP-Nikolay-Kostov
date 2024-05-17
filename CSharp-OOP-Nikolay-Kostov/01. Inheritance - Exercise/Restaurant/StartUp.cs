using Restaurant.RestaurantClasses;
using Restaurant.RestaurantClasses.BeverageClasses;
using Restaurant.RestaurantClasses.BeverageClasses.HotBeverageClasses;
using Restaurant.RestaurantClasses.FoodClasses;
using Restaurant.RestaurantClasses.FoodClasses.DessertClasses;
using Restaurant.RestaurantClasses.FoodClasses.MainDishClasses;
using Restaurant.RestaurantClasses.FoodClasses.StarterClasses;
using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());

            // Create a Product
            var product = new Product(name, price);

         // Create Food Product
            double grams = double.Parse(Console.ReadLine());
            var foodProduct = new Food(name, price, grams);

            // Create specific type of Food (MainDish)
            var mainDish = new MainDish(name, price, grams);

            // Create specific Main Dish
            var fish = new Fish(name, price);

            // Create specific type of Food (Starter)
            var starter = new Starter(name, price, grams);

            // Create specific Starter
            var soup = new Soup(name, price, grams);

            // Create specific type of Food (Dessert)
            double calories = double.Parse(Console.ReadLine());
            var dessert = new Dessert(name, price, grams, calories);

            // Create specific Dessert
            var cake = new Cake(name);

         // Create Beverage Product
            double milliliters = double.Parse(Console.ReadLine());
            var beverage = new Beverage(name, price, milliliters);

            // Create specific type of Beverage (HotBeverage)
            var hotBeverage = new HotBeverage(name, price, milliliters);

            // Create specific HotBeverage
            double caffeine = double.Parse(Console.ReadLine());
            var coffee = new Coffee(name, caffeine);

            // Create specific HotBeverage
            var tea = new Tea(name, price, milliliters);

            // Create specific type of Beverage (ColdBeverage)
            var coldBeverage = new ColdBeverage(name, price, milliliters);
        }
    }
}