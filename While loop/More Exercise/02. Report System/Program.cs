using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumWeNeeded = int.Parse(Console.ReadLine());

            double cardAvg = 0;
            double cashAvg = 0;
            int card = 0;
            int cash = 0;
            int readCard = 0;

            string price;
            while ((price = Console.ReadLine()) != "End")
            {
                int newPrice = int.Parse(price);

                readCard++;
                if (readCard % 2 == 0)
                {
                    if (newPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        card++;
                        cardAvg += newPrice;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (newPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cash++;
                        cashAvg += newPrice;
                        Console.WriteLine("Product sold!");
                    }
                }

                if (cardAvg + cashAvg >= sumWeNeeded)
                {
                    break;
                }
            }

            double priceCard = cardAvg / card;
            double priceCash = cashAvg / cash;
            
            if (cardAvg + cashAvg >= sumWeNeeded)
            {
                Console.WriteLine($"Average CS: {priceCash:f2}");
                Console.WriteLine($"Average CC: {priceCard:F2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
