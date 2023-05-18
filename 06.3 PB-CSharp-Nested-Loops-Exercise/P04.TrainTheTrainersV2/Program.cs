using System;

namespace P04.TrainTheTrainersV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string presentationName;
            int count = 0;
            double grade = 0;
            double studentGrade = 0;
            

            while (input != "Finish")
            {
                presentationName = input;
                grade = 0;

                for (int i = 1; i <= n; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                }
                grade /= n; 
                Console.WriteLine($"{presentationName} - {grade:f2}.");
                
                studentGrade += grade;
                count++;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {studentGrade/count:f2}.");
        }
    }
}
