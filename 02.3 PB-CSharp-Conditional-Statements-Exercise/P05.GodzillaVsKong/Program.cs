using System;

namespace P05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists =  int.Parse((Console.ReadLine()));  
            double cloates = double.Parse((Console.ReadLine()));

            double decore = budget * 0.1;
            double clotesTotal = cloates * statists;

            if (statists > 150) 
            {
                double bonus = clotesTotal * 0.1;
                clotesTotal = clotesTotal - bonus;
            }

            double priceTotal = clotesTotal + decore;

            if (budget < priceTotal) 
            {
                double money = priceTotal - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {money:F2} leva more.");
            }
            else
            {
                
                double money = budget - priceTotal;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {money:F2} leva left.");
                
            }


        }
    }
}
