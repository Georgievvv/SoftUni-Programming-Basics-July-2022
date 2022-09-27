using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0;
            double totalSeats = rows * colums;

            if (type == "Premiere")
            {
                income = totalSeats * 12;
            }

            else if (type == "Normal")
            {
                income = totalSeats * 7.5;
            }

            else if (type == "Discount")
            {
                income = totalSeats * 5;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
