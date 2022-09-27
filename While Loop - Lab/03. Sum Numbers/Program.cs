using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num1 > sum)
            {
                int num2 = int.Parse(Console.ReadLine());
                sum += num2;
            }
            Console.WriteLine(sum);
        }
    }
}
