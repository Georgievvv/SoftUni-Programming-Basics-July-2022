using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minNumber = double.MaxValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                double number = double.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
