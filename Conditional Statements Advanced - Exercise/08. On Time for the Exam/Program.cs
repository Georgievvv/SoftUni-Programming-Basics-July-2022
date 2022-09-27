using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());

            int hourArrived = int.Parse(Console.ReadLine());
            int minuteArrived = int.Parse(Console.ReadLine());


            int examSumInMinutes = hourExam * 60 + minuteExam;
            int arrivedSumInMinutes = hourArrived * 60 + minuteArrived;

            if (arrivedSumInMinutes > examSumInMinutes)
            {
                Console.WriteLine("Late");

                if (arrivedSumInMinutes - examSumInMinutes < 60)
                {
                    Console.WriteLine($"{arrivedSumInMinutes - examSumInMinutes} minutes after the start");
                }
                else
                {
                    int hours = (arrivedSumInMinutes - examSumInMinutes) / 60;
                    int minutes = (arrivedSumInMinutes - examSumInMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
            }

            else if (arrivedSumInMinutes == examSumInMinutes || examSumInMinutes - arrivedSumInMinutes <= 30)
            {
                Console.WriteLine("On time");

                if (arrivedSumInMinutes - examSumInMinutes != 0)
                {
                    Console.WriteLine($"{examSumInMinutes - arrivedSumInMinutes} minutes before the start");
                }
            }

            else if (examSumInMinutes - arrivedSumInMinutes > 30)
            {
                Console.WriteLine("Early");

                if (Math.Abs(arrivedSumInMinutes - examSumInMinutes) < 60)
                {
                    Console.WriteLine($"{examSumInMinutes - arrivedSumInMinutes} minutes before the start");
                }
                else
                {
                    int hours = (examSumInMinutes - arrivedSumInMinutes) / 60;
                    int minutes = (examSumInMinutes - arrivedSumInMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
            }
        }
    }
}
