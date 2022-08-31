using System;

namespace T07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfOvernights = int.Parse(Console.ReadLine());

            double price1 = 0;
            double price2 = 0;

            if (month == "May" || month == "October" )
            {
                price1 = numberOfOvernights * 50;
                price2 = numberOfOvernights * 65;
                if (numberOfOvernights > 14)
                {
                    price1 *= 0.7;
                }
                else if (numberOfOvernights > 7)
                {
                    price1 *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                price1 = numberOfOvernights * 75.20;
                price2 = numberOfOvernights * 68.70;
                if (numberOfOvernights > 14)
                {
                    price1 *= 0.8;
                }
            }
            else
            {
                price1 = numberOfOvernights * 76;
                price2 = numberOfOvernights * 77;
            }
            if (numberOfOvernights > 14)
            {
                price2 *= 0.10;
            }

            Console.WriteLine($"Apartment: {price2:f2} lv.");
            Console.WriteLine($"Studio: {price1} lv.");
        }
    }
}
