using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double area = sideA * sideA;
                Console.WriteLine(area);
            }

            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine(area);
            }

            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = radius * radius * Math.PI;
                Console.WriteLine(area);
            }

            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideH = double.Parse(Console.ReadLine());
                double area = sideA * sideH / 2;
                Console.WriteLine(area);
            }
        }
    }
}
