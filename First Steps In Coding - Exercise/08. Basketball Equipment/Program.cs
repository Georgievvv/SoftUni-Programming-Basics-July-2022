using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double shoes = tax * 0.6;
            double clothes = shoes * 0.8;
            double balls = clothes / 4;
            double accessories = balls / 5;

            double totalPrice = tax + shoes + clothes + balls + accessories;

            Console.WriteLine(totalPrice);
        }
    }
}
