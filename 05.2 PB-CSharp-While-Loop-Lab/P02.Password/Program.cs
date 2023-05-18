using System;

namespace P02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            string pass = Console.ReadLine();

            while (pass != password)
            {
                //Console.WriteLine();
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
