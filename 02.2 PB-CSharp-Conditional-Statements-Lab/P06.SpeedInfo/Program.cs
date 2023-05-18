﻿using System;

namespace P06.SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 150)
            {
                if (speed <= 50)
                {
                    if (speed <= 10)
                    {
                        Console.WriteLine("slow");
                    }
                    else
                    {
                        Console.WriteLine("average");
                    }
                }
                else
                {
                    Console.WriteLine("fast");
                }
            }
            else
            {
                if (speed <= 1000)
                {
                    Console.WriteLine("ultra fast");
                }
                else
                {
                    Console.WriteLine("extremely fast");
                }
            }
        }
    }
}
