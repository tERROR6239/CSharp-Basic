using System;
using System.Data;

namespace P06.EasterCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topBaker = "";
            int topPoints = 0;
            
            for (int i = 1; i <= n; i++) 
            {
                string bakerN = Console.ReadLine();
                int points = 0;

                string command;
                while ((command = Console.ReadLine()) != "Stop")
                {
                    int grade = int.Parse(command);
                    points += grade;
                }
                Console.WriteLine($"{bakerN} has {points} points.");
                if (points > topPoints) 
                {
                    topBaker = bakerN;
                    topPoints = points;
                    Console.WriteLine($"{topBaker} is the new number 1!");
                }
            }
            Console.WriteLine($"{topBaker} won competition with {topPoints} points!");
        }
    }
}
