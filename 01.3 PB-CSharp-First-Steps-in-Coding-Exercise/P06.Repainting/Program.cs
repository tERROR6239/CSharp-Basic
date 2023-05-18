using System;

namespace P06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine())+2;
            double paint = int.Parse(Console.ReadLine());
            paint = paint + paint * 0.1;
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            
            double summ = nylon * 1.5 + paint * 14.5 + thinner * 5 + 0.4;
            double work = (summ * 0.3) * hours;
            double summTotal = summ + work;
            
            Console.WriteLine(summTotal);
        }
    }
}
