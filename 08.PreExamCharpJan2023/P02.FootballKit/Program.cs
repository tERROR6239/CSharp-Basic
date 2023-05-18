using System;

namespace P02.FootballKit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shurtPrice = double.Parse(Console.ReadLine());
            double winSum = double.Parse(Console.ReadLine());

            double shortsPrise = shurtPrice * 0.75;
            double sockPrice = shortsPrise * 0.20;
            double sneakersPrice = (shurtPrice + shortsPrise) * 2;
            
            double sum = shurtPrice + shortsPrise + sockPrice + sneakersPrice;
            double total = sum - (sum * 0.15);

            if (total >= winSum) 
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:f2} lv.");
            }
            else 
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {winSum-total:f2} lv. more.");
            }
        }
    }
}
