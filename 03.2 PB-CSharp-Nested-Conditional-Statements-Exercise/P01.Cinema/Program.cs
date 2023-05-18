using System;

namespace P01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (type == "Premiere")
            {
                price = rows * colums * 12.00;                
            }
            else if (type == "Normal")
            {
                price = rows * colums * 7.50;
            }
            else if (type == "Discount")
            {
                price = rows * colums * 5.00;
            }

            Console.WriteLine("{0:f2} leva", price);

        }
    }
}
