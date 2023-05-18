using System;

namespace P03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 0; i < n; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num < 400) 
                {
                    p2++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4++;
                }
                else if (num >= 800 && num <= 1000)
                {
                    p5++;
                }
            }
            double per = 100.00 / n;
            Console.WriteLine($"{per * p1:F2}%");
            Console.WriteLine($"{per * p2:F2}%");
            Console.WriteLine($"{per * p3:F2}%");
            Console.WriteLine($"{per * p4:F2}%");
            Console.WriteLine($"{per * p5:F2}%");

        }
    }
}
