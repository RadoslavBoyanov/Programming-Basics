using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int packChemicals = int.Parse(Console.ReadLine());
            int packMarkers = int.Parse(Console.ReadLine());
            int literscleaner = int.Parse(Console.ReadLine());
            int percDecrease = int.Parse(Console.ReadLine());

            double priceForPackChemicals = 5.80;
            double priceForMarkers = 7.20;
            double priceCleanerPerLiter = 1.20;

            double pricePacksChemicals = packChemicals * priceForPackChemicals;
            double pricePacksMarkers = packMarkers * priceForMarkers;
            double priceCleaner = literscleaner * priceCleanerPerLiter;

            double totalSum = pricePacksChemicals + pricePacksMarkers + priceCleaner;
            double totalPriceWithDecrease = totalSum - (totalSum * (percDecrease / 100.0));

            Console.WriteLine(totalPriceWithDecrease);


        }
    }
}
