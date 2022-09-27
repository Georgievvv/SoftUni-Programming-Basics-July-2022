using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double toyCounter = 0;
            double moneyCounter = 0;
            int evenAgeCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    evenAgeCounter += 10;
                    moneyCounter += (evenAgeCounter - 1);
                }

                else
                {
                    toyCounter++;
                }
            }

            double moneyFromToys = toyCounter * toyPrice;
            double moneyFromBday = moneyCounter;
            double totalMoney = moneyFromBday + moneyFromToys;

            if (washingMachinePrice <= totalMoney)
            {
                double moneyLeft = totalMoney - washingMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }

            else
            {
                double moneyNeeded = washingMachinePrice - totalMoney;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
