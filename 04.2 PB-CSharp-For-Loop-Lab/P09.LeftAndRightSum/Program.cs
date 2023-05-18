using System;

namespace P09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 0; 
            int second = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    first = first + num;
                }

                for (int i = 1; i <= n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    second = second + num;
                }

                if (first == second)
                Console.WriteLine($"Yes, sum = {first}");
                else
                Console.WriteLine($"No, diff = {Math.Abs(first-second)}");
            }
        }
    }
}
