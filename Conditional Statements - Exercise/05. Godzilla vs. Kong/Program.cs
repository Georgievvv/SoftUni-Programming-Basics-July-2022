using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statist = double.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            double costForClothes = statist * clothes;

            if (statist > 150)
            {
                costForClothes = costForClothes - (costForClothes * 0.1);
            }

            double totalCost = costForClothes + decor;

            if (totalCost > budget)
            {
                double print = totalCost - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {print:f2} leva more.");
            }

            else
            {
                double print = budget - totalCost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {print:f2} leva left.");
            }
        }
    }
}
