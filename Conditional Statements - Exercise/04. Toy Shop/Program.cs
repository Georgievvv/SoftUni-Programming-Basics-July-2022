using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double costForVacation = double.Parse(Console.ReadLine());
            double puzzle = double.Parse(Console.ReadLine());
            double doll = double.Parse(Console.ReadLine());
            double bear = double.Parse(Console.ReadLine());
            double minion = double.Parse(Console.ReadLine());
            double truck = double.Parse(Console.ReadLine());

            double sumToys = (puzzle * 2.6) + (doll * 3) + (bear * 4.1) + (minion * 8.2) + (truck * 2);
            double countToys = puzzle + doll + bear + minion + truck;
            double moneyLeft = 0;

            if (countToys >= 50)
            {
                moneyLeft = sumToys - (sumToys * 0.25);
            }
            else
            {
                moneyLeft = sumToys;
            }

            moneyLeft = moneyLeft - (moneyLeft * 0.1);

            if (moneyLeft >= costForVacation)
            {
                double print = moneyLeft - costForVacation;
                Console.WriteLine($"Yes! {print:f2} lv left.");
            }
            else
            {
                double print = costForVacation - moneyLeft;
                Console.WriteLine($"Not enough money! {print:f2} lv needed.");
            }
        }
    }
}
