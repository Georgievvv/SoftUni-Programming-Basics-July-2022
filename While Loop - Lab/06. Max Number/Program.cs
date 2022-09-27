using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maxNumber = double.MinValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                double number = double.Parse(input);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNumber);
        }
    }
}
