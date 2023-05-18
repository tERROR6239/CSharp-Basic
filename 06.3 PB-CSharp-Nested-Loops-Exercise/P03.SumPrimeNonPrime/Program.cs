using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string data = Console.ReadLine();
            int sumP = 0;
            int sumN = 0;
            bool isPrime = true;
            while (data != "stop")
            {
                int num = int.Parse(data);
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
                        }
                    }
                    if (isPrime)
                    {
                        sumP += num;
                    }
                    else
                    {
                        sumN += num;
                    }
                }
                data = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumP}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumN}");
        }
    }
}
