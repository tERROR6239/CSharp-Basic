using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsA = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string nameC = Console.ReadLine();
                double pointsC = double.Parse(Console.ReadLine());
                pointsA = pointsA + (nameC.Length*pointsC/2.0);
                if (pointsA > 1250.5)
                    break;
            }
            if (pointsA >= 1250.5)
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointsA:F1}!");
            else
                Console.WriteLine($"Sorry, {name} you need {1250.5 - pointsA:F1} more!");
        }
    }
}
