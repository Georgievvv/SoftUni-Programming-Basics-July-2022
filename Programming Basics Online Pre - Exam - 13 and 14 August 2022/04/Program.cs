using System;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double computenCount = double.Parse(Console.ReadLine());
            double number = 0;

            double rating = 0;
            double averageRating = 0;
            double possibleSales = 0;
            double sales = 0;

            for (int i = 1; i <= computenCount; i++)
            {
                number = double.Parse(Console.ReadLine());

                rating = number % 10;

                averageRating += rating;

                possibleSales = Math.Floor(number / 10);

                if (rating <= 2) // 0
                {
                    sales += 0;
                }

                else if (rating <= 3) // 0.5
                {
                    sales += possibleSales * 0.50;
                }

                else if (rating <= 4) // 0.7
                {
                    sales += possibleSales * 0.70;
                }

                else if (rating <= 5) // 0.85
                {
                    sales += possibleSales * 0.85;
                }

                else if (rating <= 6) // 1
                {
                    sales += possibleSales;
                }
            }

            Console.WriteLine($"{sales:f2}");
            Console.WriteLine($"{averageRating / computenCount:f2}");
        }
    }
}
