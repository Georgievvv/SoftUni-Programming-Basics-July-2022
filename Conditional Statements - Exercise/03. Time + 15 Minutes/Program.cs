using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 15;

            if (hour == 23 && minute > 59)
            {
                hour = 0;
            }

            else if (minute > 59)
            {
                hour++;
            }

            if (minute > 59)
            {
                minute = minute % 60;
            }

            if (minute >= 10)
            {
                Console.WriteLine($"{hour}:{minute}");
            }

            else
            {
                Console.WriteLine($"{hour}:0{minute}");
            }
        }
    }
}
