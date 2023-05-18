using System;

namespace P00.DemoV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());

            for (char i = (char)a1; i < (char)a2; i++) 
            {
                Console.WriteLine(i);
            }  
            

            int x = int.Parse(Console.ReadLine());

            char x1 = (char)x;

            for (int i = 1; i <= 50; i++) 
            {
                Console.WriteLine(x1);
                x1++;
            }
        }
    }
}
