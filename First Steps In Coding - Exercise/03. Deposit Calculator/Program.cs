using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double totalSum = deposit + period * ((deposit * percent/100) / 12);

            Console.WriteLine(totalSum);
        }
    }
}
