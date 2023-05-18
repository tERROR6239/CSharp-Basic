using System;

namespace P03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            Console.Write("mouns: ");
            int mounts = int.Parse(Console.ReadLine());
            Console.Write("%: ");
            double percent = double.Parse(Console.ReadLine())/100;
            double summ = deposit + mounts * ((deposit * percent) / 12);
            Console.WriteLine(summ);
        }
    }
}
