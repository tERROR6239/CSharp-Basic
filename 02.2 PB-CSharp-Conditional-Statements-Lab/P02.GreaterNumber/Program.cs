using System;

namespace P02.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = (double)a / b; //Kastvane
            if (a > b) 
            {
                Console.WriteLine(a);
            }
            else 
            {
                Console.WriteLine(b);
            }
        }
    }
}
