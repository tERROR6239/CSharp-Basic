using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine())/100;
            double capacity = length*width*height;
            double liters = capacity / 1000;
            double capacityTotal = liters * (1 - percent);
            Console.WriteLine(capacityTotal);


        }
    }
}
