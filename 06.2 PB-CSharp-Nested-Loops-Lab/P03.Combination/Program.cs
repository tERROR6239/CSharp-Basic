using System;

namespace P03.Combination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for (int x3 = 0; x3 <= n; x3++)
            {
                for (int x2 = 0; x2 <= n; x2++)
                {
                    for (int x1 = 0; x1 <= n; x1++)
                    {
                        if (x3 + x2 + x1 == n)
                            i++;
                    }
                }
            }
            Console.WriteLine(i);
        }
    }
}
