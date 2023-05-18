using System;

namespace P01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            while (input!= "Stop") 
            {
                bool canParce = int.TryParse(input, out int curInput);
                if (!canParce) 
                {
                    Console.WriteLine("Invalid Input");
                    input = Console.ReadLine();
                    continue;
                }
                Console.WriteLine(curInput);
                input = Console.ReadLine();
            }
        }
    }
}
