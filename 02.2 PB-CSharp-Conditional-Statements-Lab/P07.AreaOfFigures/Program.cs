using System;
using System.IO;

namespace P07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();

            if (fig == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double result = Math.Round(sideA * sideA, 3);
                Console.WriteLine(result);
            }
            else
            {
                if (fig == "rectangle")
                {
                    double sideA = double.Parse(Console.ReadLine());
                    double sideB = double.Parse(Console.ReadLine());
                    double result = Math.Round(sideA * sideB, 3);
                    Console.WriteLine(result);
                }
                else
                {
                    if (fig == "circle")
                    {
                        double radius = double.Parse(Console.ReadLine());
                        double result = Math.Round(radius * radius * Math.PI, 3);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        if (fig == "triangle")
                        {
                            double sideA = double.Parse(Console.ReadLine());
                            double sideB = double.Parse(Console.ReadLine());
                            double result = (sideA * sideB)/2;
                            Console.WriteLine(Math.Round(result, 3));
                        }
                    }
                }
            }
        }
    }
 }