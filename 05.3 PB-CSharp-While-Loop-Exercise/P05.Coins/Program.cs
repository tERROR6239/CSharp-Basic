using System;

namespace P05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int monets = 0;

            while (change > 0)
            {
                if (change - 2.00 >= 0)
                {
                    change = Math.Round(change - 2.00, 2);
                    monets++;
                }
                else if (change - 1.00 >= 0) 
                {
                    change = Math.Round(change - 1.00, 2);
                    
                    monets++;
                }
                else if (change - 0.50 >= 0)
                {
                    change = Math.Round(change - 0.50, 2);
                    monets++;
                }
                else if (change - 0.20 >= 0)
                {
                    change = Math.Round(change - 0.20, 2);
                    monets++;
                }
                else if (change - 0.10 >= 0)
                {
                    change = Math.Round(change - 0.10, 2);
                    monets++;
                }
                else if (change - 0.05 >= 0)
                {
                    change = Math.Round(change - 0.05, 2);
                    monets++;
                }
                else if (change - 0.02 >= 0)
                {
                    change = Math.Round(change - 0.02, 2);
                    monets++;
                }
                else if (change - 0.01 >= 0)
                {
                    change = Math.Round(change - 0.01, 2);
                    monets++;
                }
            }
            Console.WriteLine(monets);
        }
    }
}
