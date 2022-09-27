using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();

            double sum = 0;
            int badGradesCounter = 0;
            int counter = 0;
            string lastProblem = "";

            while (problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                lastProblem = problemName;
                problemName = Console.ReadLine();

                if (grade <= 4)
                {
                    badGradesCounter++;

                    if (badGradesCounter == badGrade)
                    {
                        Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                        break;
                    }
                }

                sum += grade;
                counter++;
            }

            if (badGradesCounter < badGrade)
            {
                Console.WriteLine($"Average score: {sum / counter:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
