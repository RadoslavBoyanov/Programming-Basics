using System;

namespace T07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int videoCardQuantity = int.Parse(Console.ReadLine());
            int processorsQuantity = int.Parse(Console.ReadLine());
            int ramMemoryQuantity = int.Parse(Console.ReadLine());

            double videocardPrice = videoCardQuantity * 250;
            double processorsPrice = processorsQuantity * (videocardPrice * 0.35);
            double ramMemoryPrice = ramMemoryQuantity * (videocardPrice * 0.10);

            double totalPrice = videocardPrice + processorsPrice + ramMemoryPrice;

            if (videoCardQuantity > processorsQuantity)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }

            double difference = budget - totalPrice;

            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva more!");
            }
        }
    }
}
