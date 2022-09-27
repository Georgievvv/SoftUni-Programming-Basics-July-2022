using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operators = Console.ReadLine();

            double result = 0;
            string evenOrOdd = "";

            if (operators == "+")
            {
                result = num1 + num2;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }

                else if (result % 2 != 0)
                {
                    evenOrOdd = "odd";
                }

                Console.WriteLine($"{num1} + {num2} = {result} - {evenOrOdd}");
            }

            else if (operators == "-")
            {
                result = num1 - num2;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }

                else if (result % 2 != 0)
                {
                    evenOrOdd = "odd";
                }

                Console.WriteLine($"{num1} - {num2} = {result} - {evenOrOdd}");
            }

            else if (operators == "*")
            {
                result = num1 * num2;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }

                else if (result % 2 != 0)
                {
                    evenOrOdd = "odd";
                }

                Console.WriteLine($"{num1} * {num2} = {result} - {evenOrOdd}");
            }

            else if (operators == "/")
            {
                if (num1 != 0 && num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }

                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }

            else if (operators == "%")
            {
                if (num1 != 0 && num2 != 0)
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }

                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
        }
    }
}
