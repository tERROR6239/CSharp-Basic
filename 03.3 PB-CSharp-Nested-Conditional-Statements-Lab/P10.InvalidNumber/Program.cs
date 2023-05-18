using System;

namespace P10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double digit = double.Parse(Console.ReadLine());
            if (digit >= 100 && digit <= 200 || digit == 0)
                Console.WriteLine();
            else
                Console.WriteLine("invalid");
        }
    }
}
