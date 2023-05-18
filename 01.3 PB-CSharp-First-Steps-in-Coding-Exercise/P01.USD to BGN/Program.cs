using System;

namespace P01.USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("$: ");
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine($"{usd}$ = {bgn}lv.");
        }
    }
}
