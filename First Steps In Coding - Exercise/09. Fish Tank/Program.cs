using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double fullArea = double.Parse(Console.ReadLine());

            double tankVolume = (a * b * h) / 1000;
            double totalVolume = tankVolume * (1 - fullArea/100);

            Console.WriteLine(totalVolume);
        }
    }
}
