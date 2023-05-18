using System;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingM = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int sum = 0;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum = (sum + 10 * i / 2) - 1;
                }
                else
                {
                    toys += 1;
                }
            }
            int sumToys = toys * toyPrice;
            double sumTotal = sum + sumToys;

            if (sumTotal >= washingM)
                Console.WriteLine($"Yes! {sumTotal - washingM:F2}");
            else
                Console.WriteLine($"No! {washingM - sumTotal:F2}");
        }
    }
}
