using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videocard = double.Parse(Console.ReadLine());
            double procesor = double.Parse(Console.ReadLine());
            double ramMemory = double.Parse(Console.ReadLine());

            double sumVideocard = videocard * 250;
            double sumProcesor = (sumVideocard * 0.35) * procesor;
            double sumRamMemory = (sumVideocard * 0.1) * ramMemory;

            double sum = sumVideocard + sumProcesor + sumRamMemory;

            if (videocard > procesor)
            {
                sum = sum * 0.85;
            }

            if (budget >= sum)
            {
                Console.WriteLine($"You have {budget - sum:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
            }

        }
    }
}
