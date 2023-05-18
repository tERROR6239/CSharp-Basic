using System;

namespace P07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int digit = int.Parse(input);
                if (digit < min)
                    min = digit;
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
