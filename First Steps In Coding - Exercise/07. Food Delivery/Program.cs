using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double priceForMenus = (chickenMenu * 10.35) + (fishMenu * 12.4) + (veganMenu * 8.15);
            double totalPrice = priceForMenus + (priceForMenus * 0.2) + 2.5;

            Console.WriteLine(totalPrice);
        }
    }
}
