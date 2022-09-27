using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double higth = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double homeFreeSpace = width * length * higth;

            while (input != "Done")
            {
                int box = int.Parse(input);

                homeFreeSpace -= box;

                if (homeFreeSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(homeFreeSpace)} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (homeFreeSpace > 0)
            {
                Console.WriteLine($"{homeFreeSpace} Cubic meters left.");
            }
        }
    }
}
