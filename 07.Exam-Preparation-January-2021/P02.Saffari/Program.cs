using System;

namespace P02.Saffari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            
            double price = (fuel * 2.10) + 100;

            if (day == "Saturday")
            {
                price -= price * 0.1;
            }
            else if (day == "Sunday")
            {
                price -= price * 0.2;
            }

            if (budget >= price)
                Console.WriteLine($"Safari time! Money left: {budget-price:f2} lv. ");
            else
                Console.WriteLine($"Not enough money! Money needed: {price - budget:f2} lv.");
        }
    }
}
