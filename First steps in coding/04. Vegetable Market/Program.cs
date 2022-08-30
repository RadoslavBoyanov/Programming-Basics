using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForKilogramsVegatables = double.Parse(Console.ReadLine());
            double priceForKilogramsFruits = double.Parse(Console.ReadLine());
            int sumKilogramsForVegatables = int.Parse(Console.ReadLine());
            int sumKilogramsForFruits = int.Parse(Console.ReadLine());

            double totalPriceForVegatables = priceForKilogramsVegatables * sumKilogramsForVegatables;
            double totalPriceForFruits = priceForKilogramsFruits * sumKilogramsForFruits;

            double totalSum = totalPriceForVegatables + totalPriceForFruits;

            double euroSum = totalSum * (1 / 1.94);

            Console.WriteLine($"{euroSum:F2}");

        }
    }
}
