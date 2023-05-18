using System;

namespace P03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string type = Console.ReadLine();
            string  vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            if (days < 1)
                Console.WriteLine("Days must be positive number!");
            else 
            {
                double priceD = 0;
                double discount = 0;

                if (city == "Bansko" || city == "Borovets")
                {
                    if (type == "withEquipment")
                    {
                        priceD = 100;
                        discount = 0.1;
                    }
                    else if (type == "noEquipment")
                    {
                        priceD = 80;
                        discount = 0.05;
                    }
                }
                else if (city == "Varna" || city == "Burgas")
                {
                    if (type == "withBreakfast")
                    {
                        priceD = 130;
                        discount = 0.12;
                    }
                    else if (type == "noBreakfast")
                    {
                        priceD = 100;
                        discount = 0.07;
                    }
                }

                if (priceD == 0 && discount == 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (vip == "yes")
                    {
                        priceD -= priceD * discount;
                    }

                    if (days > 7)
                    {
                        days -= 1;
                    }

                    double totalP = days * priceD;
                    Console.WriteLine($"The price is {totalP:f2}lv! Have a nice time!");
                }
            }

        }
    }
}
