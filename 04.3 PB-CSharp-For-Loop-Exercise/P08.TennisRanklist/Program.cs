using System;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int events = int.Parse(Console.ReadLine());
            int pointsS = int.Parse(Console.ReadLine());
            double win = 0.0;
            double pointsT = 0.0;
            for (int i = 0; i < events; i++)
            {
                string place = Console.ReadLine();
                if (place == "W")
                {
                    pointsS += 2000;
                    pointsT += 2000;
                    win++;
                }
                else if (place == "F")
                {
                    pointsS += 1200;
                    pointsT += 1200;
                }
                else if (place == "SF")
                {
                    pointsS += 720;
                    pointsT += 720;
                }
            }
            Console.WriteLine($"Final points: {pointsS}");
            Console.WriteLine($"Average points: {Math.Floor(pointsT / events)}");
            Console.WriteLine($"{ win / events * 100:F2}%");
        }
    }
}
