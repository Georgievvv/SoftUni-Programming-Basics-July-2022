using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            double priceApartment = 0;
            double priceStudio = 0;

            switch (month)
            {
                case "May":
                case "October":
                    {
                        priceStudio = 50 * day;
                        priceApartment = 65 * day;

                        if (day > 7 && day <14)
                        {
                            priceStudio *= 0.95;
                        }

                        if (day > 14 && day > 7)
                        {
                            priceStudio *= 0.7;
                            priceApartment *= 0.9;
                        }
                    }
                    break;

                case "June":
                case "September":
                    {
                        priceStudio = 75.20 * day;
                        priceApartment = 68.70 * day;

                        if (day > 14)
                        {
                            priceStudio *= 0.8; 
                            priceApartment *= 0.9;
                        }
                    }
                    break;

                case "July":
                case "August":
                    {
                        priceStudio = 76 * day;
                        priceApartment = 77 * day;

                        if (day > 14)
                        {
                            priceApartment *= 0.9;
                        }
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
