using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < rows; i++)
            {
                int number = int.Parse(Console.ReadLine());
                totalSum += number;
            }

            Console.WriteLine(totalSum);
        }
    }
}
