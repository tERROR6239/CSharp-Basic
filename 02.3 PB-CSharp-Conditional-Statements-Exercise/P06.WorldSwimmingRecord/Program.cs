using System;

namespace P06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeMeter = double.Parse(Console.ReadLine());

            double timeTemp = distance * timeMeter;
            double waterResist = Math.Floor(distance / 15) * 12.5;
            double timeTotal = timeTemp + waterResist;

            if (record > timeTotal) 
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeTotal:F2} seconds.");
            }
            else
            {
                double time = timeTotal - record;
                Console.WriteLine($"No, he failed! He was {time:F2} seconds slower.");
            }

        }
    }
}
