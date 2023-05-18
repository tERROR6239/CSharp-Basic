using System;

namespace P06.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double digit = double.Parse(Console.ReadLine());
            if (digit >= -100 && digit <= 100)
            {
                if (digit != 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else
                Console.WriteLine("No");
        }
    }
}
