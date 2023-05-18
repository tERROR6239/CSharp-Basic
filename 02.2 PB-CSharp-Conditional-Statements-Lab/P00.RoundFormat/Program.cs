using System;

namespace P00.RoundFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Math.PI;
            //Rounding -> Works with double, pure math operation.
            Console.WriteLine(Math.Round(a, 5));
            //Formating  -> Wworks with strings, pure stilistical operation.
            Console.WriteLine($"{a:f5}");


            if (a > 1)
            { }
            else if (a > 3)
            { }
            else if(a > 4)
            { }
            else
            { }
        }
    }
}
