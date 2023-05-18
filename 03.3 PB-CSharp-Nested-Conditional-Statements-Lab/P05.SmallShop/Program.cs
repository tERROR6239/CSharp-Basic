using System;

namespace P05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                switch (item)
                {
                    case "coffee":
                        Console.WriteLine(count*0.5);
                        break;
                    case "water":
                        Console.WriteLine(count * 0.8);
                        break;
                    case "beer":
                        Console.WriteLine(count * 1.2);
                        break;
                    case "sweets":
                        Console.WriteLine(count * 1.45);
                        break;
                    case "peanuts":
                        Console.WriteLine(count * 1.6);
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (item)
                {
                    case "coffee":
                        Console.WriteLine(count * 0.4);
                        break;
                    case "water":
                        Console.WriteLine(count * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(count * 1.15);
                        break;
                    case "sweets":
                        Console.WriteLine(count * 1.30);
                        break;
                    case "peanuts":
                        Console.WriteLine(count * 1.50);
                        break;
                }
            }
            else if (city == "Varna")
            {
                switch (item)
                {
                    case "coffee":
                        Console.WriteLine(count * 0.45);
                        break;
                    case "water":
                        Console.WriteLine(count * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(count * 1.1);
                        break;
                    case "sweets":
                        Console.WriteLine(count * 1.35);
                        break;
                    case "peanuts":
                        Console.WriteLine(count * 1.55);
                        break;
                }
            }
        }
    }
}