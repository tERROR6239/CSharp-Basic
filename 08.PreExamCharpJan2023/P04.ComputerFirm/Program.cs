using System;

namespace P04.ComputerFirm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int reiting = 0;
            double reitingT = 0.0;
            int selsP = 0;
            double selsR = 0.0;
            double selsT = 0.0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                reiting = number % 10;
                selsP = number / 10;

                if (reiting == 2)
                {
                    selsR = selsP * 0.00;
                }
                else if (reiting == 3)
                {
                    selsR = selsP * 0.50;
                }
                else if (reiting == 4)
                {
                    selsR = selsP * 0.70;
                }
                else if (reiting == 5)
                {
                    selsR = selsP * 0.85;
                }
                else if (reiting == 6)
                {
                    selsR = selsP * 1.00;
                }

                reitingT += reiting;
                selsT += selsR;
            }

            Console.WriteLine($"{selsT:f2}");
            Console.WriteLine($"{reitingT/n:f2}");
        }
    }
}
