using System;

namespace P09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomTipe = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0.0;

            if (roomTipe == "room for one person")
            {
                price = 18.00 * (days - 1);
                if (rating == "positive")
                    price = price + (price * 0.25);
                else if (rating == "negative")
                    price = price - (price * 0.10);
            }
            else if (roomTipe == "apartment")
            {
                price = 25.00 * (days - 1);
                if (days < 10)
                    price = price - (price * 0.30);
                else if (days >= 10 && days <= 15)
                    price = price - (price * 0.35);
                else if (days > 15)
                    price = price - (price * 0.50);

                if (rating == "positive")
                    price = price + (price * 0.25);
                else if (rating == "negative")
                    price = price - (price * 0.10);
            }
            else if (roomTipe == "president apartment")
            {
                price = 35.00 * (days - 1);
                if (days < 10)
                    price = price - (price * 0.10);
                else if (days >= 10 && days <= 15)
                    price = price - (price * 0.15);
                else if (days > 15)
                    price = price - (price * 0.20);

                if (rating == "positive")
                    price = price + (price * 0.25);
                else if (rating == "negative")
                    price = price - (price * 0.10);
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
