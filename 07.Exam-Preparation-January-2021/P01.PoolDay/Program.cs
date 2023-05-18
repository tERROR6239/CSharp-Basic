using System;

namespace P01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleC = int.Parse(Console.ReadLine());
            double ticketP = double.Parse(Console.ReadLine());
            double chairP = double.Parse(Console.ReadLine());
            double umbrelaP = double.Parse(Console.ReadLine());

            int umbrelaC = (int)Math.Ceiling(peopleC / 2.0);
            int chairC = (int)Math.Ceiling(peopleC * 0.75);

            double totalP = (peopleC * ticketP) + (umbrelaC * umbrelaP) + (chairC * chairP);

            Console.WriteLine($"{totalP:f2} lv.");
        }

    }
}
