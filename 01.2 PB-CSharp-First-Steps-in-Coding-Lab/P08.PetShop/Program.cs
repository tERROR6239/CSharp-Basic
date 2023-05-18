using System;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dog food count: ");
            int foodDog = int.Parse(Console.ReadLine());
            Console.Write("Cat food count: ");
            int foodCat = int.Parse(Console.ReadLine());
            double price = foodDog * 2.5 + foodCat * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
}
