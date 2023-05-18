using System;

namespace P02.Nums1To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);

            //type name =  value;
            int wholeNum = 5;  // imena - Camel case
            double pi = 3.14;
            string name = "CSharp";
            char ch = 'A';
            Console.WriteLine(wholeNum+pi+name+ch);
     ;

            Console.Write("Enter your name: ");
            string nameConsole = Console.ReadLine();
            Console.WriteLine("Hello, " + nameConsole);

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());
            Console.WriteLine("Age, " + age);
            Console.WriteLine("Heigh, " + heigh);
            //var - universalno za vseki tip ako ne iska6 da pi6e6 tipa
            Console.WriteLine($"Hello, {nameConsole}!");

        }
    }
}
