using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pens: ");
            int pens = int.Parse(Console.ReadLine());
            Console.Write("Pensil: ");
            int pensil = int.Parse(Console.ReadLine());
            Console.Write("Cleaning: ");
            int clean = int.Parse(Console.ReadLine());
            Console.Write("Discount: ");
            double disc = double.Parse(Console.ReadLine());
            double summ = (pens * 5.8) + (pensil * 7.2) + (clean * 1.2);
            double discSum = (disc / 100) * summ;
            double sumTotal = summ - discSum;
            Console.WriteLine(sumTotal);

        }
    }
}
