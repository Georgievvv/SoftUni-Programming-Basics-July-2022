using System;

namespace _02._Numbers_N_To_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = input; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
