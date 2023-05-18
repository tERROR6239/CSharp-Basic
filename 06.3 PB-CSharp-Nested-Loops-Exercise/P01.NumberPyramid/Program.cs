using System;

namespace P01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool bigger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        bigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (bigger) 
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
