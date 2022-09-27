using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;

            while (count <= number)
            {
                Console.WriteLine(count);
                count = count* 2 + 1;
            }
        }
    }
}
