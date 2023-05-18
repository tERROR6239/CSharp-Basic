using System;

namespace P01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            string book = Console.ReadLine();
            int i = 0;
            while (true)
            {                
                if (book == searchBook)
                {
                    Console.WriteLine($"You checked {i} books and found it.");
                    break;
                }

                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {i} books.");
                    break;
                }

                i++;
                book = Console.ReadLine();
            }
        }
    }
}
