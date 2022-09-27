using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruitType = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" ||
                day == "Tuesday" ||
                day == "Wednesday" ||
                day == "Thursday" ||
                day == "Friday")
            {
                switch (fruitType)
                {
                    case "banana":
                        double print1 = quantity * 2.50;
                        Console.WriteLine($"{print1:f2}");
                        break;

                    case "apple":
                        double print2 = quantity * 1.20;
                        Console.WriteLine($"{print2:f2}");
                        break;

                    case "orange":
                        double print3 = quantity * 0.85;
                        Console.WriteLine($"{print3:f2}");
                        break;

                    case "grapefruit":
                        double print4 = quantity * 1.45;
                        Console.WriteLine($"{print4:f2}");
                        break;

                    case "kiwi":
                        double print5 = quantity * 2.70;
                        Console.WriteLine($"{print5:f2}");
                        break;

                    case "pineapple":
                        double print6 = quantity * 5.50;
                        Console.WriteLine($"{print6:f2}");
                        break;

                    case "grapes":
                        double print7 = quantity * 3.85;
                        Console.WriteLine($"{print7:f2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruitType)
                {
                    case "banana":
                        double print1 = quantity * 2.70;
                        Console.WriteLine($"{print1:f2}");
                        break;

                    case "apple":
                        double print2 = quantity * 1.25;
                        Console.WriteLine($"{print2:f2}");
                        break;

                    case "orange":
                        double print3 = quantity * 0.90;
                        Console.WriteLine($"{print3:f2}");
                        break;

                    case "grapefruit":
                        double print4 = quantity * 1.60;
                        Console.WriteLine($"{print4:f2}");
                        break;

                    case "kiwi":
                        double print5 = quantity * 3.00;
                        Console.WriteLine($"{print5:f2}");
                        break;

                    case "pineapple":
                        double print6 = quantity * 5.60;
                        Console.WriteLine($"{print6:f2}");
                        break;

                    case "grapes":
                        double print7 = quantity * 4.20;
                        Console.WriteLine($"{print7:f2}");
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
