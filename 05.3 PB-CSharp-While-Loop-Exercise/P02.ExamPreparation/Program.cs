using System;
using System.Diagnostics.CodeAnalysis;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowGrades = int.Parse(Console.ReadLine());
            int lowCount = 0;
            double sum = 0.0;
            int examCount = 0;
            string problem = "";

            while (true) 
            {
                string examName = Console.ReadLine();

                if (examName == "Enough")
                {
                    Console.WriteLine($"Average score: {sum / examCount:F2}");
                    Console.WriteLine($"Number of problems: {examCount}");
                    Console.WriteLine($"Last problem: {problem}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                                
                if (grade <= 4)
                    lowCount++;
                    sum += grade;
                    examCount++;
                
                if (lowCount >= lowGrades)
                {
                    Console.WriteLine($"You need a break, {lowCount} poor grades.");
                    break;
                }

                problem = examName;
                
            }
        }
    }
}
