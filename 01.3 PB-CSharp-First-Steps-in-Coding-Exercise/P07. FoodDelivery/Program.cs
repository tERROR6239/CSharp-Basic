using System;

namespace P07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chiken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double summ = chiken * 10.35 + fish * 12.4 + vegan * 8.15;
            double dessert = summ * 0.2;
            double summTotal = summ + dessert + 2.5;
            Console.WriteLine(summTotal);
        }
    }
}
