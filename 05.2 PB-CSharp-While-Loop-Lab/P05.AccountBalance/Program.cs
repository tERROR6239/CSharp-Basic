using System;
using System.Xml.Schema;

namespace P05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double summ = 0;
            double total = 0;
            while (money != "NoMoreMoney") 
            {
                summ = double.Parse(money);
                if (summ > 0)
                {
                    Console.WriteLine($"Increase: {summ:F2}");
                    total += summ;
                }
                else 
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                money = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
