﻿using System;

namespace P08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Thursday":
                case "Wednesday":
                    Console.WriteLine(14);
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}