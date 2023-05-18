using System;

namespace P06.ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Family Name: ");
            string familyName = Console.ReadLine();
            Console.Write("Enter your Age: ");
            string age = Console.ReadLine();
            Console.Write("Enter your City: ");
            string city = Console.ReadLine();
            Console.WriteLine($"You are {name} {familyName}, a {age}-years old person from {city}.");
        }
    }
}
