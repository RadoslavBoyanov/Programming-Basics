using System;

namespace T05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string summerOrWinter = Console.ReadLine();

            double price = 0;
            string destination = "";
            string campOrHotel = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (summerOrWinter == "summer")
                {
                    price = budget * 0.30;
                }
                else
                {
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (summerOrWinter == "summer")
                {
                    price = budget * 0.40;
                }
                else
                {
                    price = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                price = budget * 0.90;
            }

            if (summerOrWinter == "winter" || destination == "Europe")
            {
                campOrHotel = "Hotel";
            }
            else
            {
                campOrHotel = "Camp";
            }
            
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {price:f2}");
        }
    }
}
