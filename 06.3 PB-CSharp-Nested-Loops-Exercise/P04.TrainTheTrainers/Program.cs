using System;

namespace P04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentatoin = Console.ReadLine();
            double finaleA = 0;
            double totalS = 0;
            int j = 0;

            while (presentatoin != "Finish")
            {

                for (int i = 1; i <= n; i++)
                {
                    double assest = double.Parse(Console.ReadLine());
                    finaleA += assest;
                }
                Console.WriteLine($"{presentatoin} - {finaleA / n:f2}.");
                j++;
                totalS += finaleA;
                finaleA = 0;
                presentatoin = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalS / (j * n):f2}.");
        }
    }
}
