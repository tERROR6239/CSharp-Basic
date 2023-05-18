using System;

namespace P07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double bonus = 0;

            double gpuPrice = gpu * 250;
            double cpuPrice = cpu * (gpuPrice * 0.35);
            double ramPrice = ram * (gpuPrice * 0.1); 
            double price = gpuPrice+cpuPrice+ramPrice;

            if (gpu > cpu) 
            {
                bonus = price * 0.15;
                price = price - bonus;
            }

            if (budget >= price)
            {
                double money = budget - price;
                Console.WriteLine($"You have {money:f2} leva left!");
            }
            else
            {                
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget-price):f2} leva more!");
            }
        }
    }
}
