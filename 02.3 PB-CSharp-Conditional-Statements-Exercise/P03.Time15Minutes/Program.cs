using System;

namespace P03.Time15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int totalTime = (hour * 60 + minute) + 15;
            int hourT = totalTime / 60;
            if (hourT > 23)
            {
                hourT = hourT - 24;
            }

            int minuteT = totalTime % 60;
            if (minuteT < 10)
            {
                Console.WriteLine($"{hourT}:0{minuteT}");
            }
            else
            {
                Console.WriteLine($"{hourT}:{minuteT}");
            }



        }
    }
}
