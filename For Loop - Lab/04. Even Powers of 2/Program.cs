using System;

namespace _04._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= input; i += 2)
            {
                Console.WriteLine(num);
                num *= 2 * 2;
            }
        }
    }
}
