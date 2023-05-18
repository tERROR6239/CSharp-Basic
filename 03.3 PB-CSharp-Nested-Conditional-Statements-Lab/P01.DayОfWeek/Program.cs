using System;

namespace P01.DayОfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            if (digit >= 1 & digit <= 7) 
            {
                if (digit == 1)
                    Console.WriteLine("Monday");
                else if (digit == 2)
                    Console.WriteLine("Tuesday");
                else if (digit == 3)
                    Console.WriteLine("Wednesday");
                else if (digit == 4)
                    Console.WriteLine("Thursday");
                else if (digit == 5)
                    Console.WriteLine("Friday");
                else if (digit == 6)
                    Console.WriteLine("Saturday");
                else 
                    Console.WriteLine("Sunday");
            }
            else
                Console.WriteLine("Error");
        }
    }
}
