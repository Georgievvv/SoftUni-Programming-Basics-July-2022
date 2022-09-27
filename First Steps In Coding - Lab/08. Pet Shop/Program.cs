using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine());
            int catFoodCount = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogFoodCount * 2.5;
            double catFoodPrice = catFoodCount * 4;

            double totalPrice = dogFoodPrice + catFoodPrice;

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
