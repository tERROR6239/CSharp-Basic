﻿using System;

namespace P09.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plant = Console.ReadLine();
            switch (plant)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}