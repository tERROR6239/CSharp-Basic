using System;

namespace P08.OnTimeForTheExam
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

            string status = "";
            string offset = "";

            int time = 0;
            int timeH = 0;
            int timeM = 0;

            if (student < exam - 30)
            {
                status = "Early";
                offset = "before";
            }
            else if (student >= exam - 30 && student <= exam)
            {
                status = "On time";
                offset = "before";
            }
            else
            {
                status = "Late";
                offset = "after";
            }
            Console.WriteLine(status);

            time = Math.Abs(exam - student);
            if (time > 0 && time <= 9)
                Console.WriteLine($"{time} minutes {offset} the start");
            else if (time > 10 && time <= 59)
                Console.WriteLine($"{time} minutes {offset} the start");
            else if (time > 60)
            {
                timeH = time / 60;
                timeM = time % 60;
                if (timeH > 23) 
                   timeH = timeH - 24;

                if (timeM >= 0 && timeM <= 9)
                    Console.WriteLine($"{timeH}:0{timeM} hours {offset} the start");
                else if (timeM > 10 && timeM <= 59)
                    Console.WriteLine($"{timeH}:{timeM} hours {offset} the start");
            }
        }
    }
}
