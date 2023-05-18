using System;

namespace P04.FitnessCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peapleC = int.Parse(Console.ReadLine());
            int backk = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int shake = 0;
            int bar = 0;
            
            for (int i = 1; i <= peapleC; i++)
            {
                string training = Console.ReadLine();
                
                if (training == "Back")
                {
                    backk++; 
                }
                else if (training == "Chest")
                {
                    chest++;
                }
                else if (training == "Legs")
                {
                    legs++;
                }
                else if (training == "Abs")
                {
                    abs++;
                }
                else if (training == "Protein shake")
                {
                    shake++;
                }
                else if (training == "Protein bar")
                {
                    bar++;
                }
            }
            double trainingC = backk + chest + legs + abs;
            double proteinC = peapleC - trainingC;
            double percentP = ((double)trainingC / peapleC) * 100;

            double proteinP = ((double)proteinC / peapleC) * 100;

            Console.WriteLine($"{backk} - back");
            Console.WriteLine($"{chest} - chest");            
            Console.WriteLine($"{legs} - legs");            
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{shake} - protein shake");
            Console.WriteLine($"{bar} - protein bar");
            Console.WriteLine($"{percentP:f2}% - work out");
            Console.WriteLine($"{proteinP:f2}% - protein");
        }
    }
}
