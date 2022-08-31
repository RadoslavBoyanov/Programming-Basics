using System;

namespace T09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0;
            double positiveOrNegative = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    price = (dayStay - 1) * 18.00;
                    break;
                case "apartment":
                    price = (dayStay - 1) * 25.00;
                    if (dayStay < 10)
                    {
                        price *= 0.7;
                    }
                    else if (dayStay <=15)
                    {
                        price *= 0.65;
                    }
                    else
                    {
                        price *= 0.5;
                    }
                    break;
                case "president apartment":
                    price = (dayStay - 1) * 35.00;
                    if (dayStay < 10)
                    {
                        price *= 0.9;
                    }
                    else if (dayStay <= 15)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price *= 0.8;
                    }        
                    break;
                default:
                    break;
            }
            
            if (rating == "positive")
            {
                positiveOrNegative = price + (price * 0.25);
            }
            else
            {
                positiveOrNegative = price - (price * 0.10);
            }

            Console.WriteLine($"{positiveOrNegative:f2}");
        }
    }
}
