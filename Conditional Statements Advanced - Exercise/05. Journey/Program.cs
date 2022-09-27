using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string printLocation = "";
            string hotelType = "";

            if (budget <= 100)
            {
                printLocation = "Bulgaria";

                switch (season)
                {
                    case "summer":
                        {
                            hotelType = "Camp";
                            price = budget * 0.3;
                        }
                        break;

                    case "winter":
                        {
                            hotelType = "Hotel";
                            price = budget * 0.7;
                        }
                        break;
                }
            }

            else if (budget <= 1000)
            {
                printLocation = "Balkans";

                switch (season)
                {
                    case "summer":
                        {
                            hotelType = "Camp";
                            price = budget * 0.4;
                        }
                        break;

                    case "winter":
                        {
                            hotelType = "Hotel";
                            price = budget * 0.8;
                        }
                        break;
                }
            }

            else
            {
                hotelType = "Hotel";
                printLocation = "Europe";
                price = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {printLocation}");
            Console.WriteLine($"{hotelType} - {price:f2}");
        }
    }
}
