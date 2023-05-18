using System;
using System.Diagnostics;

namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceS = 0.0;
            double priceA = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    {
                        priceA = 65.00 * nights;
                        if (nights > 7 && nights<= 14)
                            priceS = 50.00 * nights - (50.00 * 0.05 * nights);
                        else if (nights > 14)
                            priceS = 50.00 * nights - (50.00 * 0.30 * nights);
                        else
                            priceS = 50.00 * nights;
                    }
                    break;
                case "June":
                case "September":
                    {
                        priceA = 68.70 * nights;
                        if (nights > 14)
                            priceS = 75.20 * nights - (75.20 * 0.20 * nights);
                        else
                            priceS = 75.20 * nights;
                    }
                    break;
                case "July":
                case "August":
                    {
                        priceA = 77.00 * nights;
                        priceS = 76.00 * nights;
                    }
                    break;
            }

            if (nights > 14)
                priceA = priceA - (priceA * 0.10);

            Console.WriteLine($"Apartment: {priceA:F2} lv.");
            Console.WriteLine($"Studio: {priceS:F2} lv.");
        }
    }
}