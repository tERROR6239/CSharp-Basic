using System;
using System.Numerics;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            bool flag = false;
            int num1 = 0; 
            int num2 = 0;

            int i = 0;
            for (int x3 = begin; x3 <= end; x3++)
            {
                for (int x2 = begin; x2 <= end; x2++)
                {
                    i++;
                    if (x3 + x2 == magic)
                    {
                        num1 = x3;
                        num2 = x2;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    break;
            }
            if(flag == true)
            Console.WriteLine($"Combination N:{i} ({num1} + {num2} = {magic})");
            else
            Console.WriteLine($"{i} combinations - neither equals {magic}");
        }
    }
}
