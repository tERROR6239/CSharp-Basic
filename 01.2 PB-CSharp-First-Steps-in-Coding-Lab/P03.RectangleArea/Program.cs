using System;

namespace P03.RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side A: ");
            int sideA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int sideB = int.Parse(Console.ReadLine());
            int area = 0;
            area = sideA * sideB;
            Console.Write($"Rectangle area = {area}");

        }
    }
}
