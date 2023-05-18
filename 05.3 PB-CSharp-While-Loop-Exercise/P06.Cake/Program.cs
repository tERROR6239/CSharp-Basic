using System;
using System.Runtime.Serialization;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int cake = w * l;
            string pieces = Console.ReadLine();

            while (pieces != "GGHF")
            {
                if (pieces == "STOP")
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    break;
                }

                int tmp = int.Parse(pieces);
                cake -= tmp;

                if (cake <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    break;
                }
                pieces = Console.ReadLine();
            }
        }
    }
}
