using System;

namespace P04.InchToCenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Inches: ");
            double inch = double.Parse(Console.ReadLine());
            //double centi = 0;
            double centi = inch * 2.54;
            Console.Write($"{inch} Inches are equal to {centi} Centimeters");
        }
    }
}
