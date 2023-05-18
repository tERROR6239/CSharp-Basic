using System;

namespace P03.SumPrimeNonPrimeV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num;
            int sumP = 0;
            int sumN = 0;
            bool isPrime = true;
            while (input != "stop")
            {
                num = int.Parse(input);
                isPrime = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }                    
                }
                if (isPrime && num > 0)
                {
                    sumP += num;
                }
                else if (num > 0)
                {
                    sumN += num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumP}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumN}");
        }
    }
}
