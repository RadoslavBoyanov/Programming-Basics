using System;

namespace T01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroup = int.Parse(Console.ReadLine());

            double price = 0;
            double priceForTransport = 0;

            if (category == "VIP")
            {
                price = peopleInGroup * 499.99;
            }
            else
            {
                price = peopleInGroup * 249.99;
            }

            if (peopleInGroup >= 1 && peopleInGroup <=4)
            {
                priceForTransport = budget * 0.75; 
            }
            else if (peopleInGroup <=9)
            {
                priceForTransport = budget * 0.60;
            }
            else if (peopleInGroup <= 24)
            {
                priceForTransport = budget * 0.50;
            }
            else if (peopleInGroup <= 49)
            {
                priceForTransport = budget * 0.40;
            }
            else
            {
                priceForTransport = budget * 0.25;
            }
            
            if (budget >= price + priceForTransport)
            {
                Console.WriteLine($"Yes! You have {budget - (price + priceForTransport):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price + priceForTransport) - budget:f2} leva.");
            }
        }
    }
}
