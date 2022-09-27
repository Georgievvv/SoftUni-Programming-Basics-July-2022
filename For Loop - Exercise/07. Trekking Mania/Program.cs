using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GroupCount = int.Parse(Console.ReadLine());

            double musalaGroup = 0;
            double montBlancGroup = 0;
            double kilimanjaroGroup = 0;
            double k2Group = 0;
            double everestGroup = 0;

            for (int i = 1; i <= GroupCount; i++)
            {
                int climbersPerGroup = int.Parse(Console.ReadLine());

                if (climbersPerGroup < 6)
                {
                    musalaGroup += climbersPerGroup;
                }

                else if (climbersPerGroup < 13)
                {
                    montBlancGroup += climbersPerGroup;
                }

                else if (climbersPerGroup < 26)
                {
                    kilimanjaroGroup += climbersPerGroup;
                }

                else if (climbersPerGroup < 41)
                {
                    k2Group += climbersPerGroup;
                }

                else 
                {
                    everestGroup += climbersPerGroup;
                }
            }

            double totalClimbers = musalaGroup + montBlancGroup + kilimanjaroGroup + k2Group + everestGroup;

            double group1 = 1.0 * musalaGroup / totalClimbers * 100;
            double group2 = 1.0 * montBlancGroup / totalClimbers * 100;
            double group3 = 1.0 * kilimanjaroGroup / totalClimbers * 100;
            double group4 = 1.0 * k2Group / totalClimbers * 100;
            double group5 = 1.0 * everestGroup / totalClimbers * 100;

            Console.WriteLine($"{group1:f2}%");
            Console.WriteLine($"{group2:f2}%");
            Console.WriteLine($"{group3:f2}%");
            Console.WriteLine($"{group4:f2}%");
            Console.WriteLine($"{group5:f2}%");
        }
    }
}
