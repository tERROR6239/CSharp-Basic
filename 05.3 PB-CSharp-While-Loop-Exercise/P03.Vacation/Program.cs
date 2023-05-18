using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeed = double.Parse(Console.ReadLine());
            double moneyStart = double.Parse(Console.ReadLine());
            double moneySaved = 0.0;
            int days = 0;
            int i = 0;
            bool tmp = true;

            while (moneyNeed > moneyStart)
            {
                string operation = Console.ReadLine();
                moneySaved = double.Parse(Console.ReadLine());

                if (operation == "spend")
                {
                    moneyStart -= moneySaved;
                    days++;
                    i++;
                    if (moneyStart < 0)
                        moneyStart = 0;
                }
                else if (operation == "save")
                {
                    moneyStart += moneySaved;
                    days++;
                    i = 0;
                }

                if (i == 5)
                {
                    tmp = false;
                    break;
                }
            }
            if (tmp)
                Console.WriteLine($"You saved the money for {days} days.");
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
        }
    }
}
