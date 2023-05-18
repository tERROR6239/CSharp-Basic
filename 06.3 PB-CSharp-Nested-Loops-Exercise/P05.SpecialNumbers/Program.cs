using System;

namespace P05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int c = 1;

            for (int l = 1; l <= 9; l++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if(n % l == 0 && n % j == 0 && n % k == 0 && n % i == 0)
                            Console.Write($"{l}{j}{k}{i} ");
                        }
                    }                    
                }
            }
        }
    }
}
