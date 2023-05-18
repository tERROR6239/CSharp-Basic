using System;

namespace P12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sels = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (sels >= 0 && sels <= 500)
                    Console.WriteLine("{0:F2}", sels * 0.05);
                else if (sels > 500 && sels <= 1000)
                    Console.WriteLine("{0:F2}", sels * 0.07);
                else if (sels > 1000 && sels <= 10000)
                    Console.WriteLine("{0:F2}", sels * 0.08);
                else if (sels > 1000)
                    Console.WriteLine("{0:F2}", sels * 0.12);
                else
                    Console.WriteLine("error");
            }
            else if (city == "Varna")
            {
                if (sels >= 0 && sels <= 500)
                    Console.WriteLine("{0:F2}", sels * 0.045);
                else if (sels > 500 && sels <= 1000)
                    Console.WriteLine("{0:F2}", sels * 0.075);
                else if (sels > 1000 && sels <= 10000)
                    Console.WriteLine("{0:F2}", sels * 0.10);
                else if (sels > 1000)
                    Console.WriteLine("{0:F2}", sels * 0.13);
                else
                    Console.WriteLine("error");
            }
            else if (city == "Plovdiv")
            {
                if (sels >= 0 && sels <= 500)
                    Console.WriteLine("{0:F2}", sels * 0.055);
                else if (sels > 500 && sels <= 1000)
                    Console.WriteLine("{0:F2}", sels * 0.08);
                else if (sels > 1000 && sels <= 10000)
                    Console.WriteLine("{0:F2}", sels * 0.12);
                else if (sels > 1000)
                    Console.WriteLine("{0:F2}", sels * 0.145);
                else
                    Console.WriteLine("error");
            }
            else
                Console.WriteLine("error");
        }
    }
}