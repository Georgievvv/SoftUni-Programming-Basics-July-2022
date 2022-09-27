using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double movieLength = double.Parse(Console.ReadLine());
            double breakTime = double.Parse(Console.ReadLine());

            double timeLeft = breakTime - (breakTime * 1 / 8) - (breakTime * 1 / 4);
            double timeDifference = 0;

            if (timeLeft >= movieLength)
            {
                timeDifference = Math.Ceiling(timeLeft - movieLength);

                Console.WriteLine($"You have enough time to watch {movieName} and left with {timeDifference} minutes free time.");
            }

            else
            {
                timeDifference = Math.Ceiling(movieLength - timeLeft);

                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {timeDifference} more minutes.");
            }
        }
    }
}
