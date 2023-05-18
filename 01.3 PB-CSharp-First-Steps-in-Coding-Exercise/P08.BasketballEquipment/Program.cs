using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxx = double.Parse(Console.ReadLine());
            double boots = taxx - (taxx * 0.4);
            double dress = boots - (boots * 0.2);
            double ball = dress / 4;
            double accesoar = ball / 5;
            double summ = taxx + boots + dress + ball + accesoar;
            Console.WriteLine(summ);

        }
    }
}
