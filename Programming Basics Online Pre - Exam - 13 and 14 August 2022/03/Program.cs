using System;

namespace Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            switch (season)
            {
                case "spring":
                    if (people <= 5)
                    {
                        price = 50.00;
                    }
                    else
                    {
                        price = 48.00;
                    }
                    totalPrice = price * people;
                    break;


                case "summer":
                    if (people <= 5)
                    {
                        price = 48.50;
                    }
                    else
                    {
                        price = 45.00;
                    }
                    totalPrice = (price * 0.85) * people;
                    break;


                case "autumn":
                    if (people <= 5)
                    {
                        price = 60.00;
                    }
                    else
                    {
                        price = 49.50;
                    }
                    totalPrice = price * people;
                    break;


                case "winter":
                    if (people <= 5)
                    {
                        price = 86.00;
                    }
                    else
                    {
                        price = 85.00;
                    }
                    totalPrice = (price * 1.08) * people;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2} leva.");
        }
    }
}
