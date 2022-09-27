using System;

namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportTicketsCount = int.Parse(Console.ReadLine());
            int museumTicketsCount = int.Parse(Console.ReadLine());

            double totalSum = ((nights * 20) + (transportTicketsCount * 1.6) + (museumTicketsCount * 6)) * peopleCount;

            double finalPrice = totalSum * 1.25;

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
