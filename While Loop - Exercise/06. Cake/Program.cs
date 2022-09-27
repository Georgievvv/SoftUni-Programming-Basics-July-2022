using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cakeSideA = double.Parse(Console.ReadLine());
            double cakeSideB = double.Parse(Console.ReadLine());

            double cakeSize = cakeSideA * cakeSideB;

            while (cakeSize > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                double pieces = double.Parse(input);

                cakeSize -= pieces;
            }

            if (cakeSize >= 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }

            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
        }
    }
}
