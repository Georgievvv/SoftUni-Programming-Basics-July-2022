using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    {
                        if (fisherman <= 6)
                        {
                            price = 3000;
                            price *= 0.9;
                        }

                        else if (fisherman <= 11)
                        {
                            price = 3000;
                            price *= 0.85;
                        }

                        else if (fisherman > 12)
                        {
                            price = 3000;
                            price *= 0.75;
                        }

                        if (fisherman % 2 == 0)
                        {
                            price *= 0.95;
                        }
                    }
                    break;

                case "Summer":
                    {
                        if (fisherman <= 6)
                        {
                            price = 4200;
                            price *= 0.9;
                        }

                        else if (fisherman <= 11)
                        {
                            price = 4200;
                            price *= 0.85;
                        }

                        else if (fisherman > 12)
                        {
                            price = 4200;
                            price *= 0.75;
                        }

                        if (fisherman % 2 == 0)
                        {
                            price *= 0.95;
                        }
                    }
                    break;

                case "Autumn":
                    {
                        if (fisherman <= 6)
                        {
                            price = 4200;
                            price *= 0.9;
                        }

                        else if (fisherman <= 11)
                        {
                            price = 4200;
                            price *= 0.85;
                        }

                        else if (fisherman > 12)
                        {
                            price = 4200;
                            price *= 0.75;
                        }
                    }
                    break;

                case "Winter":
                    {
                        if (fisherman <= 6)
                        {
                            price = 2600;
                            price *= 0.9;
                        }

                        else if (fisherman <= 11)
                        {
                            price = 2600;
                            price *= 0.85;
                        }

                        else if (fisherman > 12)
                        {
                            price = 2600;
                            price *= 0.75;
                        }

                        if (fisherman % 2 == 0)
                        {
                            price *= 0.95;
                        }
                    }
                    break;
            }

            if (budget >= price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (budget < price)
            {
                double moneyNeeded = price - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
