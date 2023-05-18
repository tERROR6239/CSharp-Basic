using System;
using System.Globalization;

namespace P02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());           

            for (int i = first; i <= second; i++)
            {
                string current = i.ToString();
                int even = 0;
                int odd = 0;

                for (int j = 0; j < current.Length; j++)
                {
                    int currentDigit = int.Parse(current[j].ToString());
                    if (j % 2 == 0)
                        even += currentDigit;
                    else
                        odd += currentDigit;
                }
                if (even == odd) 
                {
                    Console.Write(i + " ");
                }
            }    
        }
    }
}
