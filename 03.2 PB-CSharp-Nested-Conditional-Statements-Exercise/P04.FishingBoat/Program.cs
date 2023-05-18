using System;
using System.Diagnostics;

namespace P04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (season == "Spring")
            {
                if (fishermans > 6 && fishermans <= 11)
                    price = 3000 - (3000 * 0.15);
                else if (fishermans >12)
                    price = 3000 - (3000 * 0.25);
                else
                    price = 3000 - (3000 * 0.10);
            }
            else if (season == "Summer")
            {
                if (fishermans > 6 && fishermans <= 11)
                    price = 4200 - (4200 * 0.15);
                else if (fishermans > 12)
                    price = 4200 - (4200 * 0.25);
                else
                    price = 4200 - (4200 * 0.10);
            }
            else if (season == "Autumn")
            {
                if (fishermans > 6 && fishermans <= 11)
                    price = 4200 - (4200 * 0.15);
                else if (fishermans > 12)
                    price = 4200 - (4200 * 0.25);
                else
                    price = 4200 - (4200 * 0.10);
            }
            else if (season == "Winter")
            {
                if (fishermans > 6 && fishermans <= 11)
                    price = 2600 - (2600 * 0.15);
                else if (fishermans > 12)
                    price = 2600 - (2600 * 0.25);
                else
                    price = 2600 - (2600 * 0.10);
            }

            if (fishermans % 2 == 0 && season != "Autumn")
                price = price - (price * 0.05);

            if (budget >= price)
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");

        }
    }
}
