using System;

namespace P01.ChristmasPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollsPaper = int.Parse(Console.ReadLine());
            int rollsCloth = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discountP = double.Parse(Console.ReadLine());
            double price = 0;

            double paperCost = rollsPaper * 5.80;
            double clothCost = rollsCloth * 7.20;
            double glueCost = glue * 1.20;

            double sum = paperCost + clothCost + glueCost;
            price = sum - (sum * ((double)discountP / 100));

            Console.WriteLine($"{price:f3}");
        }
    }
}
