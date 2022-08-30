using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double sneakersPrice = annualTax - (0.4 * annualTax);
            double equipPrice = sneakersPrice - (0.2 * sneakersPrice);
            double ballPrice = equipPrice * 0.25;
            double accessoriesPrice = ballPrice * 0.20;

            double totalSum = annualTax + sneakersPrice + equipPrice + ballPrice + accessoriesPrice;

            Console.WriteLine(totalSum);
        }
    }
}
