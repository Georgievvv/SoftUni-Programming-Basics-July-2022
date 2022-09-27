using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (sales > 0 && sales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        double print1 = sales * 0.050;
                        Console.WriteLine($"{print1:f2}");
                        break;

                    case "Varna":
                        double print2 = sales * 0.045;
                        Console.WriteLine($"{print2:f2}");
                        break;

                    case "Plovdiv":
                        double print3 = sales * 0.055;
                        Console.WriteLine($"{print3:f2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;

                }
            }

            else if (sales > 0 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        double print1 = sales * 0.070;
                        Console.WriteLine($"{print1:f2}");
                        break;

                    case "Varna":
                        double print2 = sales * 0.075;
                        Console.WriteLine($"{print2:f2}");
                        break;

                    case "Plovdiv":
                        double print3 = sales * 0.080;
                        Console.WriteLine($"{print3:f2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

            }

            else if (sales > 0 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        double print1 = sales * 0.08;
                        Console.WriteLine($"{print1:f2}");
                        break;

                    case "Varna":
                        double print2 = sales * 0.1;
                        Console.WriteLine($"{print2:f2}");
                        break;

                    case "Plovdiv":
                        double print3 = sales * 0.12;
                        Console.WriteLine($"{print3:f2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

            }

            else if (sales > 0 && sales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        double print1 = sales * 0.12;
                        Console.WriteLine($"{print1:f2}");
                        break;

                    case "Varna":
                        double print2 = sales * 0.13;
                        Console.WriteLine($"{print2:f2}");
                        break;

                    case "Plovdiv":
                        double print3 = sales * 0.145;
                        Console.WriteLine($"{print3:f2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

            }

            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
