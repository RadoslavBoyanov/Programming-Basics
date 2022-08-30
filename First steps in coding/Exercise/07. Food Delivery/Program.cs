using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuQua = int.Parse(Console.ReadLine());
            int fishMenuQua = int.Parse(Console.ReadLine());
            int vegeterianMenuQua = int.Parse(Console.ReadLine());

            double priceChickenMenu = 10.35;
            double priceFishMenu = 12.40;
            double priceVegeterianMenu = 8.15;
            double priceDev = 2.50;

            double totalPriceForChiken = chickenMenuQua * priceChickenMenu;
            double totalPriceForFish = fishMenuQua * priceFishMenu;
            double totalProceForVegeterian = vegeterianMenuQua * priceVegeterianMenu;

            double totalPrice = totalPriceForChiken + totalPriceForFish + totalProceForVegeterian;

            double priceDesert = totalPrice * 0.20;

            double sum = totalPrice + priceDesert + priceDev;

            Console.WriteLine(sum);
        }
    }
}
