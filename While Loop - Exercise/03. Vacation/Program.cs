using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double totalMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendDaysCount = 0;

            while (totalMoney < tripPrice)
            {
                string command = Console.ReadLine();
                double currMoney = double.Parse(Console.ReadLine());

                daysCounter++;

                if (command == "spend")
                {
                    spendDaysCount++;

                    totalMoney -= currMoney;

                    if (totalMoney < 0)
                    {
                        totalMoney = 0;
                    }

                    if (spendDaysCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }
                }

                else if (command == "save")
                {
                    spendDaysCount = 0;

                    totalMoney += currMoney;
                }

                if (totalMoney >= tripPrice)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                }
            }
        }
    }
}
