using System;

namespace P07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Architect name: ");
            string name = Console.ReadLine();
            Console.Write("Project count: ");
            int proj = int.Parse(Console.ReadLine());
            int time = proj * 3;
            Console.WriteLine($"The architect {name} will need {time} hours to complete {proj} project/s.");

        }
    }
}
