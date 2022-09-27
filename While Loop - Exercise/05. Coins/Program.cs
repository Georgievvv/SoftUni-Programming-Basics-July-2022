using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = Math.Floor(double.Parse(Console.ReadLine()) * 100);
            int count = 0;

            while (input != 0)
            {
                if (input - 200 >= 0)
                {
                    input -= 200;
                    count++;
                }

                else if (input - 100 >= 0)
                {
                    input -= 100;
                    count++;
                }

                else if (input - 50 >= 0)
                {
                    input -= 50;
                    count++;
                }

                else if (input - 20 >= 0)
                {
                    input -= 20;
                    count++;
                }

                else if (input - 10 >= 0)
                {
                    input -= 10;
                    count++;
                }

                else if (input - 5 >= 0)
                {
                    input -= 5;
                    count++;
                }

                else if (input - 2 >= 0)
                {
                    input -= 2;
                    count++;
                }

                else if (input - 1 >= 0)
                {
                    input -= 1;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
