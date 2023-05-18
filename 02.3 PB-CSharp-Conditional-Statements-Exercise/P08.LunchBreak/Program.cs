using System;

namespace P08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = (double)breakTime / 8;
            double relaxTime = (double)breakTime / 4;
            double timeLeft = breakTime - lunchTime - relaxTime;

            if (timeLeft >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeLeft - episodeTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeTime - timeLeft)} more minutes.");
            }
        }
    }
}
