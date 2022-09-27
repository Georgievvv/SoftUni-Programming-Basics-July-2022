using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string roomRating = Console.ReadLine();
            
            int nights = days - 1;
            double price = 0;

            if (roomType == "room for one person")
            {
                price = nights * 18;
            }

            else if (roomType == "apartment")
            {
                if (days < 10)
                {
                    price = nights * 25;
                    price *= 0.7;
                }
                else if (days >= 10 && days < 15)
                {
                    price = nights * 25;
                    price *= 0.65;
                }
                else if (days > 15)
                {
                    price = nights * 25;
                    price *= 0.5;
                }
            }

            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    price = nights * 35;
                    price *= 0.9;
                }
                else if (days >= 10 && days < 15)
                {
                    price = nights * 35;
                    price *= 0.85;
                }
                else if (days > 15)
                {
                    price = nights * 35;
                    price *= 0.8;
                }
            }

            if (roomRating == "positive")
            {
                price *= 1.25;
            }

            else if (roomRating == "negative")
            {
                price *= 0.9;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
