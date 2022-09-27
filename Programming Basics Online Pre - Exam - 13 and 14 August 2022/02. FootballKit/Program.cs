using System;

namespace _02._FootballKit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tShirtPrice = double.Parse(Console.ReadLine());
            double neededPrice = double.Parse(Console.ReadLine());

            double shortsPrice = tShirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double shoesPrice = (tShirtPrice + shortsPrice) * 2;

            double totalPrice = (shortsPrice + socksPrice + shoesPrice + tShirtPrice) * 0.85;

            if (totalPrice >= neededPrice)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPrice:f2} lv.");
            }

            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(neededPrice - totalPrice):f2} lv. more.");
            }
        }
    }
}
