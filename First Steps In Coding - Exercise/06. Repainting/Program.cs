using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double paintТhinner = double.Parse(Console.ReadLine());
            double hoursNeeded = double.Parse(Console.ReadLine());
            double plasticBag = 0.4;

            double materialsPrice =
            ((nylon + 2) * 1.5) + ((paint * 1.1) * 14.5) + (paintТhinner * 5) + plasticBag;

            double workersPrice = (materialsPrice * 0.3) * hoursNeeded;
            double totalSum = workersPrice + materialsPrice;

            Console.WriteLine(totalSum);
        }
    }
}
