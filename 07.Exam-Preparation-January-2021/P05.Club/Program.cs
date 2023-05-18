using System;

namespace P05.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double win = double.Parse(Console.ReadLine());
            bool target = false;
            double sum = 0;
            string coctailN;

            while ((coctailN = Console.ReadLine()) != "Party!")
            {
                int coctailC = int.Parse(Console.ReadLine());
                double coctailP = coctailN.Length * coctailC;
                
                if (coctailP % 2 != 0) 
                {
                    coctailP -= coctailP * 0.25;
                }

                sum += coctailP;

                if (sum >= win)
                {
                    target = true;
                    break;
                }
            }
            if (target) 
            {
                Console.WriteLine($"Target acquired.");
            }
            else 
            {
                double moneyN = win - sum;
                Console.WriteLine($"We need {moneyN:f2} leva more."); 
            }
            Console.WriteLine($"Club income - {sum:f2} leva.");
        }
    }
}
