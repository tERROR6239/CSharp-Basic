using System;
using System.Xml.Schema;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int g5 = 0;
            double total = 0.0;
            for (int i = 0; i < g; i++)
            {
                int num = int.Parse(Console.ReadLine());
                total += num;
                if (num <= 5)
                {
                    g1 += num;
                }
                else if (num >= 6 && num <= 12)
                {
                    g2+= num;
                }
                else if (num >= 13 && num <= 25)
                {
                    g3 += num;
                }
                else if (num >= 26 && num <= 40)
                {
                    g4 += num;
                }
                else if (num >= 41)
                {
                    g5 += num;
                }
            }
            
            Console.WriteLine($"{g1 / total * 100:F2}%");
            Console.WriteLine($"{g2 / total * 100:F2}%");
            Console.WriteLine($"{g3 / total * 100:F2}%");
            Console.WriteLine($"{g4 / total * 100:F2}%");
            Console.WriteLine($"{g5 / total * 100:F2}%");
        }
    }
}
