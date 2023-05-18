using System;
using System.Diagnostics.CodeAnalysis;

namespace P08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int grade = 1; 
            int classRep = 0;
            while (grade <= 12) 
            {
                double currGrade = double.Parse(Console.ReadLine());
                if (currGrade < 4)
                {
                    classRep ++;
                    if (classRep > 1) 
                    {
                        break;
                    }
                    continue;
                }                               
                    sum += currGrade;
                    grade++;
            }
                if (classRep > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                }
                else 
                {
                    double average = sum / (grade - 1);
                    Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
                }
        }
    }
}
