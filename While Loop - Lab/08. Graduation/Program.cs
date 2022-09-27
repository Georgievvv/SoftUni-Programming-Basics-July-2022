using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());
            double totalRating = 0;
            double avgRating = 0;
            int grade = 1;
            int fails = 0;

            while (grade <= 12)
            {
                if (rating < 4.00)
                {
                    fails++;
                }

                if (fails == 2)
                {
                    grade--;
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }

                totalRating += rating;
                avgRating = totalRating / grade; 
                grade++;

                if (grade > 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {avgRating:f2}");
                    break;
                }

                rating = double.Parse(Console.ReadLine());
            }
        }
    }
}
