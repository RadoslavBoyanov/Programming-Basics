using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hoursForWork = int.Parse(Console.ReadLine());

            double priceNylon = 1.50;
            double pricePaint = 14.50;
            double priceDiluent = 5.00;
            double pricePlasticBags = 0.40;

            double sumForNylon = (nylon + 2) * priceNylon;
            double sumForPaint = (paint + (10/100.0 * paint)) * pricePaint;
            double sumForDiluent = diluent * priceDiluent;

            double totalSumForMaterials = sumForNylon + sumForPaint + sumForDiluent + pricePlasticBags;
            double sumForBuilder = (totalSumForMaterials * 0.30) * hoursForWork;
            double finalPrice = totalSumForMaterials + sumForBuilder;

            Console.WriteLine(finalPrice);
        }
    }
}
