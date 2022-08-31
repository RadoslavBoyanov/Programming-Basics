using System;

namespace Т03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsQua = int.Parse(Console.ReadLine());
            int rosesQua = int.Parse(Console.ReadLine());
            int tulipsQua = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char y = char.Parse(Console.ReadLine());

            double priceOfBouquets = 0;

            if (season == "Spring" || season == "Summer" || season == "Autumn" || season == "Winter")
            {
                if (season == "Spring" || season == "Summer")
                {
                    priceOfBouquets = chrysanthemumsQua * 2 + rosesQua * 4.10 + tulipsQua * 2.50;
                }
                else
                {
                    priceOfBouquets = chrysanthemumsQua * 3.75 + rosesQua * 4.50 + tulipsQua * 4.15;
                }

                if (y == 'Y')
                {
                    priceOfBouquets = priceOfBouquets + (priceOfBouquets * 0.15);
                }
                
                if (tulipsQua > 7 && season == "Spring")
                {
                    priceOfBouquets *= 0.95;
                }

                if (rosesQua >= 10 && season == "Winter")
                {
                    priceOfBouquets *= 0.90;
                }

                if (chrysanthemumsQua + rosesQua + tulipsQua >= 20)
                {
                    priceOfBouquets *= 0.80;
                }

                priceOfBouquets += 2;

                Console.WriteLine($"{priceOfBouquets:f2}");
            }
        }
    }
}
