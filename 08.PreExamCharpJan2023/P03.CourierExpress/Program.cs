using System;

namespace P03.CourierExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());
            double priceKM = 0;

            if (type == "standard")
            {
                if (weight < 1)
                {
                    priceKM = 0.03;
                }
                else if (weight >= 1 && weight < 10)
                {
                    priceKM = 0.05;
                }
                else if (weight >= 10 && weight < 40)
                {
                    priceKM = 0.10;
                }
                else if (weight >= 40 && weight < 90)
                {
                    priceKM = 0.15;
                }
                else if (weight >= 90 && weight < 150)
                {
                    priceKM = 0.20;
                }
            }
            else if (type == "express")
            {
                if (weight < 1)
                {

                    priceKM = 0.03 + ((0.03 * 0.80) * weight);
                }
                else if (weight >= 1 && weight < 10)
                {
                    priceKM = 0.05 + ((0.05 * 0.40) * weight);
                }
                else if (weight >= 10 && weight < 40)
                {
                    priceKM = 0.10 + ((0.10 * 0.05) * weight);
                }
                else if (weight >= 40 && weight < 90)
                {
                    priceKM = 0.15 + ((0.15 * 0.02) * weight);
                }
                else if (weight >= 90 && weight < 150)
                {
                    priceKM = 0.20 + ((0.20 * 0.01) * weight);
                }
            }

            double cost = distance * priceKM;

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {cost:f2} lv.");

        }
    }
}
