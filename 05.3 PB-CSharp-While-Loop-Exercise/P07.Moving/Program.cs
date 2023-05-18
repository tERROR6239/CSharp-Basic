using System;

namespace P07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int space = w * l * h;
            string boxes = Console.ReadLine();

            while (boxes != "GGHF")
            {
                if (boxes == "Done")
                {
                    Console.WriteLine($"{space} Cubic meters left.");
                    break;
                }

                int tmp = int.Parse(boxes);
                space -= tmp;

                if (space <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
                    break;
                }
                boxes = Console.ReadLine();
            }
        }
    }
}
