using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double time1 = distance * timeForOneMeter;
            double time2 = Math.Floor(distance / 15) * 12.5;

            double totalTime = time1 + time2;

            if (record < totalTime)
            {
                double print = totalTime - record;
                Console.WriteLine($"No, he failed! He was {print:f2} seconds slower.");
            }

            else
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
