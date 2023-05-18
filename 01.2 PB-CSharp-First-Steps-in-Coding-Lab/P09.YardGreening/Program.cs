using System;

namespace P09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yard size: ");
            double yard = double.Parse(Console.ReadLine());
            double price = yard * 7.61;
            double disc = price * 0.18;
            double priceTotal = price - disc;
            Console.WriteLine($"The final price is: {priceTotal} lv.");
            Console.WriteLine($"The discount is: {disc} lv.");
        }
    }
}
