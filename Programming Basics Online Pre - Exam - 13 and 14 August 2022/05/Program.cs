using System;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string namePrint = "";
            int best = 0;

            while (name != "END")
            {
                int goalCount = int.Parse(Console.ReadLine());

                if (best < goalCount)
                {
                    best = goalCount;
                    namePrint = name;
                }

                if (goalCount >= 10)
                {
                    break;
                }

                name = Console.ReadLine();

            }

            Console.WriteLine($"{namePrint} is the best player!");

            if (best >= 3)
            {
                Console.WriteLine($"He has scored {best} goals and made a hat-trick !!!");
            }

            else
            {
                Console.WriteLine($"He has scored {best} goals.");
            }


        }
    }
}
