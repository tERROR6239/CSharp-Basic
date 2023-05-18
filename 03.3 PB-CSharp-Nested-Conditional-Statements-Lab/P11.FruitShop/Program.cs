using System;

namespace P11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    {
                        switch (fruit)
                        { 
                            case "banana":
                                Console.WriteLine("{0:F2}", count * 2.5);
                                break;
                            case "apple":
                                Console.WriteLine("{0:F2}", count * 1.2);
                                break;
                            case "orange":
                                Console.WriteLine("{0:F2}", count * 0.85);
                                break;
                            case "grapefruit":
                                Console.WriteLine("{0:F2}", count * 1.45);
                                break;
                            case "kiwi":
                                Console.WriteLine("{0:F2}", count * 2.7);
                                break;
                            case "pineapple":
                                Console.WriteLine("{0:F2}", count * 5.5);
                                break;
                            case "grapes":
                                Console.WriteLine("{0:F2}", count * 3.85);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    {
                        switch (fruit)
                        {
                            case "banana":
                                Console.WriteLine("{0:F2}", count * 2.7);
                                break;
                            case "apple":
                                Console.WriteLine("{0:F2}", count * 1.25);
                                break;
                            case "orange":
                                Console.WriteLine("{0:F2}", count * 0.9);
                                break;
                            case "grapefruit":
                                Console.WriteLine("{0:F2}", count * 1.6);
                                break;
                            case "kiwi":
                                Console.WriteLine("{0:F2}", count * 3.0);
                                break;
                            case "pineapple":
                                Console.WriteLine("{0:F2}", count * 5.6);
                                break;
                            case "grapes":
                                Console.WriteLine("{0:F2}", count * 4.2);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}