using System;

namespace P07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double summ = 0.0;
            for (int i = 1; i <= n; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                summ = summ + num;
            }
            Console.WriteLine(summ);
        }
    }
}
