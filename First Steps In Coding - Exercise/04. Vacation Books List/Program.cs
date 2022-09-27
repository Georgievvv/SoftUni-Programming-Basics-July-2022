using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int daysNeeded = int.Parse(Console.ReadLine());


            double hoursPerDay = totalPages / pagesForHour / daysNeeded;

            Console.WriteLine(hoursPerDay);
        }
    }
}
