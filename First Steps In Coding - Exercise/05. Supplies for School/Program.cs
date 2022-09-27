using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int cleaningAgent = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double price = (pen * 5.8) + (marker * 7.2) + (cleaningAgent * 1.2);
            double finalPrice = price - (price * discount / 100);

            Console.WriteLine(finalPrice);
        }
    }
}
