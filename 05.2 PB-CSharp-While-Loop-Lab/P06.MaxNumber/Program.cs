using System;

namespace P06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;

            while (input != "Stop")
            {
                int digit = int.Parse(input);
                if(digit > max)
                    max = digit;
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
