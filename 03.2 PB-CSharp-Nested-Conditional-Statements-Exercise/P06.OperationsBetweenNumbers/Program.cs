using System;

namespace P06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;
            string even = "";

            if (operation == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                    even = "even";
                else
                    even = "odd";
                Console.WriteLine($"{num1} + {num2} = {result} - {even}");
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                    even = "even";
                else
                    even = "odd";
                Console.WriteLine($"{num1} - {num2} = {result} - {even}");
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                    even = "even";
                else
                    even = "odd";
                Console.WriteLine($"{num1} * {num2} = {result} - {even}");
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                    Console.WriteLine($"Cannot divide {num1} by zero");
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:F2}");
                }
            }
            else if (operation == "%")
            {
                if (num2 == 0)
                    Console.WriteLine($"Cannot divide {num1} by zero");
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }                
            }
        }
    }
}
