using System;

namespace P06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int f = 1; f <= floors; f++)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (floors == f)
                        Console.WriteLine($"L{f}{r}");
                    else if (f % 2 == 0)
                        Console.WriteLine($"O{f}{r}");
                    else
                        Console.WriteLine($"A{f}{r}");
                }
            }
        }
    }
}
