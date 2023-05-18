using System;
using System.Numerics;

namespace P05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerN;
            int mostG = 0;
            string bestP = "";

            while ((playerN = Console.ReadLine()) != "END") 
            {
                int goals = int.Parse(Console.ReadLine());

                if (mostG < goals) 
                {
                    mostG = goals;
                    bestP = playerN;
                }

                if (goals >= 10) 
                {
                    break;
                }
            }
            Console.WriteLine($"{bestP} is the best player!");
            if (mostG >= 3)
            {
                Console.WriteLine($"He has scored {mostG} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {mostG} goals.");
            }
        }
    }
}
