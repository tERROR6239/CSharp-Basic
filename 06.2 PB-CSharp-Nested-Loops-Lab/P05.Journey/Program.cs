using System;

namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();           
            double budget = 0.0;

            while (destination != "End") 
            {
                budget = double.Parse(Console.ReadLine());
                while (budget > 0) 
                {
                    budget -= double.Parse(Console.ReadLine());                    
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();                
            }
        }
    }
}
