using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            double flowerCount = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double rosesPrice = 0;
            double dahliasPrice = 0;
            double tulipsPrice = 0;
            double narcissusPrice = 0;
            double gladiolusPrice = 0;

            if (flowerType == "Roses")
            {
                rosesPrice = flowerCount * 5;

                if (flowerCount > 80)
                {
                    rosesPrice = rosesPrice * 0.9;
                }
            }

            else if (flowerType == "Dahlias")
            {
                dahliasPrice = flowerCount * 3.8;

                if (flowerCount > 90)
                {
                    dahliasPrice = dahliasPrice * 0.85;
                }
            }

            else if (flowerType == "Tulips")
            {
                tulipsPrice = flowerCount * 2.8;

                if (flowerCount > 80)
                {
                    tulipsPrice = tulipsPrice * 0.85;
                }
            }

            else if (flowerType == "Narcissus")
            {
                narcissusPrice = flowerCount * 3;

                if (flowerCount < 120)
                {
                    narcissusPrice = narcissusPrice * 1.15;
                }
            }

            else if (flowerType == "Gladiolus")
            {
                gladiolusPrice = flowerCount * 2.5;

                if (flowerCount < 80)
                {
                    gladiolusPrice = gladiolusPrice * 1.2;
                }
            }

            double totalPrice = rosesPrice + dahliasPrice + tulipsPrice + narcissusPrice + gladiolusPrice;

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;

                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {moneyLeft:f2} leva left.");
            }

            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
