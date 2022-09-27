using System;

namespace _03._Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double area = sideA * sideB;

            Console.WriteLine(area);
        }
    }
}
