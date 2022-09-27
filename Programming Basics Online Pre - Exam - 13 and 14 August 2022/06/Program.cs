using System;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            for (int b1 = 1; b1 <= input % 10; b1++)
            {
                for (int b2 = 1; b2 <= input / 10 % 10; b2++)
                {
                    for (int b3 = 1; b3 <= input / 100; b3++)
                    {
                        Console.WriteLine($"{b1} * {b2} * {b3} = {b3 * b2 * b1};");
                    }
                }
            }
        }
    }
}
