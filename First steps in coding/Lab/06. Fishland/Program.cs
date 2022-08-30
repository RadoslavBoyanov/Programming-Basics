using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPriceOnKg = double.Parse(Console.ReadLine());
            double spratPriceOnKg = double.Parse(Console.ReadLine());
            double bonitoOnKg = double.Parse(Console.ReadLine());
            double scadOnKg = double.Parse(Console.ReadLine());
            int musselsOnKg = int.Parse(Console.ReadLine());

            double bonitoPriceForKg = mackerelPriceOnKg + (0.60 * mackerelPriceOnKg);
            double bonitoPrice = bonitoOnKg * bonitoPriceForKg;

            double scadPriceForKg = spratPriceOnKg + (0.80 * spratPriceOnKg);
            double scadPrice = scadOnKg * scadPriceForKg;

            double musselsPriceForKg = 7.50;
            double musselsPrice = musselsOnKg * musselsPriceForKg;

            double bill = bonitoPrice + scadPrice + musselsPrice;

            Console.WriteLine($"{bill:F2}");
        }
    }
}
