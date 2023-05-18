using System;

namespace P02.RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            double radians = double.Parse(Console.ReadLine());
            double degree =  radians * 180 / Math.PI;
            Console.WriteLine($"{radians} Radians are {degree} Degres");
        }
    }
}
