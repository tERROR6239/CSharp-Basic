using System;

namespace P04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pages count: ");
            int pagesBook = int.Parse(Console.ReadLine());
            Console.Write("pages per hour: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("days for reading: ");
            int days = int.Parse(Console.ReadLine());
            int hours = (pagesBook/pages)/days;
            Console.WriteLine(hours);

        }
    }
}
