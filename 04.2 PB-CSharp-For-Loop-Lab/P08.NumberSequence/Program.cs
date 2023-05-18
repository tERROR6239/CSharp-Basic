using System;

namespace P08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num > max)
                        max = num;
                    if (num < min) 
                        min = num;
                }
                Console.WriteLine($"Max number: {max}");
                Console.WriteLine($"Min number: {min}");
            }
        }
    }
}
