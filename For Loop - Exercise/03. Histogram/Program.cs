using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }

                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }

                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }

                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }

                else if (number >= 800)
                {
                    p5++;
                }
            }

            p1 *= 1.0 / count * 100;
            p2 *= 1.0 / count * 100;
            p3 *= 1.0 / count * 100;
            p4 *= 1.0 / count * 100;
            p5 *= 1.0 / count * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
