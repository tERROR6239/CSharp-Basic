using System;
using System.Globalization;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double free = 0.0;
            int student = 0;
            int s = 0;
            int standart = 0;
            int t = 0;
            int kid = 0;
            int k = 0;
            double full = 0;
            string movieName;

            while (input != "Finish")
            {
                movieName = input;
                s = t = k = 0;
                free = int.Parse(Console.ReadLine());

                for (int i = 0; i < free; i++)
                {
                    string type = Console.ReadLine();
                    if (type == "student")
                    {
                        s++;
                        student++;
                    }
                    else if (type == "standard")
                    {
                        t++;
                        standart++;
                    }
                    else if (type == "kid")
                    {
                        k++;
                        kid++;
                    }
                    else if (type == "End")
                    {
                        break;
                    }
                }
                full = (100 / free) * (s + t + k);
                Console.WriteLine($"{movieName} - {full:f2}% full.");
                
                input = Console.ReadLine();
                
            }
            double sum = student + standart + kid;
            double sellS = (100 / sum) * student;
            double sellT = (100 / sum) * standart;
            double sellK = (100 / sum) * kid;

            Console.WriteLine($"Total tickets: {sum}");
            Console.WriteLine($"{sellS:F2}% student tickets.");
            Console.WriteLine($"{sellT:F2}% standard tickets.");
            Console.WriteLine($"{sellK:F2}% kids tickets.");
        }
    }
}
