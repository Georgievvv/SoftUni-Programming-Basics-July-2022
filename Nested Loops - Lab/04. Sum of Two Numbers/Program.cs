using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinations = 0;
            bool flag = false;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {

                    combinations++;

                    if (i + j == magicNum)
                    {
                        flag = true;
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNum})");
                        break;
                    }

                }

                if (flag)
                {
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
