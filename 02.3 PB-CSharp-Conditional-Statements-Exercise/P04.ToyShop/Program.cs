using System;

namespace P04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double travel = double.Parse(Console.ReadLine());
            int puzzs = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truks = int.Parse(Console.ReadLine());

            int toys = puzzs + dolls + bears + minions + truks;
            double summ = puzzs * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + truks * 2;
            double summTotal = 0;


            if (toys >= 50) 
            {
                double bonus = summ * 0.25;
                double summTemp = summ - bonus;
                double taxx = summTemp * 0.1;
                summTotal = summTemp - taxx;
            }
            else
            {
                double taxx = summ * 0.1;
                summTotal = summ - taxx;
            }

            if (summTotal >= travel)
            {
                double moneLeft = summTotal - travel;
                Console.WriteLine($"Yes! {moneLeft:F2} lv left.");
            }
            else
            {
                double moneLeft = travel - summTotal;
                Console.WriteLine($"Not enough money! {moneLeft:F2} lv needed.");
            }
        }


    }
}
