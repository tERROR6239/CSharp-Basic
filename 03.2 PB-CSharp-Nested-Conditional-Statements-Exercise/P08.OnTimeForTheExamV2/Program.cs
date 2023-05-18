using System;

namespace P08.OnTimeForTheExamV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int studentH = int.Parse(Console.ReadLine());
            int studentM = int.Parse(Console.ReadLine());

            int exam = examH * 60 + examM;
            int student = studentH * 60 + studentM;
            int time = exam - student;
           
            if (time < 0)
            {
                Console.WriteLine("Late");
                if (time > -60)
                {
                    Console.WriteLine($"{Math.Abs(time)} minutes after the start");
                }
                else 
                {
                    Console.WriteLine($"{Math.Abs(time / 60)}:{Math.Abs(time % 60):D2} hours after the start");
                }

                
            }
            else if (time  >= 0 && time <= 30)
            {
                Console.WriteLine("On time");
                if (time > 0)
                {
                    Console.WriteLine($"{time} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (time < 60)
                {
                    Console.WriteLine($"{time} minutes before the start");
                }
                else 
                {
                    Console.WriteLine($"{time / 60}:{time % 60:D2} hours before the start");
                }
            }
            
        }
    }
}
