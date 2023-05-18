using System;

namespace P06.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= s; j++)
                {
                    for (int h = 1; h <= t; h++)
                    {
                        if (i % 2 == 0 && h % 2 == 0) 
                        {
                            if (j >= 2 && j <= 7 && j != 4 && j != 6)
                            {
                                Console.WriteLine($"{i} {j} {h}");
                            }
                        }
                    }
                }
            }
        }
    }
}
