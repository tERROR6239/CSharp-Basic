using System;

namespace P03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flour = Console.ReadLine();
            int countF = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (flour)
            {
                case "Roses":
                    {
                        if (countF > 80)
                            price = (countF * 5) - (countF * 5 * 0.1);
                        else
                            price = countF * 5;
                    }
                    break;
                case "Tulips":
                    {
                        if (countF > 80)
                            price = (countF * 2.80) - (countF * 2.80 * 0.15);
                        else
                            price = countF * 2.80;
                    }
                    break;
                case "Dahlias":
                    {
                        if (countF > 90)
                            price = (countF * 3.80) - (countF * 3.80 * 0.15);
                        else
                            price = countF * 3.80;
                    }
                    break;
                case "Narcissus":
                    {
                        if (countF >= 120)
                            price = (countF * 3);
                        else
                            price = countF * 3 + (countF * 3 * 0.15);
                    }
                    break;
                case "Gladiolus":
                    {
                        if (countF >= 80)
                            price = (countF * 2.50);
                        else
                            price = countF * 2.50 + (countF * 2.50 * 0.2);
                    }
                    break;                
            }
            if (budget >= price)
                Console.WriteLine($"Hey, you have a great garden with {countF} {flour} and {budget - price:F2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
        }
    }
}
