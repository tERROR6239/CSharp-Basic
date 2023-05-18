using System;

namespace P03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int sum = 0;
            while (digit > sum) 
            {
                int tmp = int.Parse(Console.ReadLine());
                sum += tmp;
                
            }
            Console.WriteLine(sum);
        }
    }
}
