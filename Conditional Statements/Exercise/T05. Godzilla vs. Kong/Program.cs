using System;

namespace T05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extraCount = int.Parse(Console.ReadLine());
            double priceOfClothesPerOneExtra = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;

            double totalPriceOfClothes = extraCount * priceOfClothesPerOneExtra;

            if (extraCount > 150)
            {
                totalPriceOfClothes = totalPriceOfClothes - (totalPriceOfClothes * 0.10);
            }

            double sumClothesAndDecor = decorPrice + totalPriceOfClothes;

            if (sumClothesAndDecor >= budget)
            {
                double neededMoney = sumClothesAndDecor - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double remainingMoney = budget - sumClothesAndDecor;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainingMoney:f2} leva left.");
            }
        }
    }
}
