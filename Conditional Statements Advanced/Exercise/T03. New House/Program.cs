using System;

namespace T03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceFlowers = 0;

            if (flowers == "Roses" || flowers == "Dahlias" || flowers == "Tulips" || flowers == "Narcissus" || flowers == "Gladiolus")
            {
                if (flowers == "Roses")
                {
                    priceFlowers = countFlowers * 5;
                    if (countFlowers > 80)
                    {
                        priceFlowers = priceFlowers - (priceFlowers * 0.10);
                    }
                }
                else if (flowers == "Dahlias")
                {
                    priceFlowers = countFlowers * 3.80;
                    if (countFlowers > 90)
                    {
                        priceFlowers -= priceFlowers * 0.15;
                    }
                }
                else if (flowers == "Tulips")
                {
                    priceFlowers = countFlowers * 2.80;
                    if (countFlowers > 80)
                    {
                        priceFlowers *= 0.85;
                    }
                }
                else if (flowers == "Narcissus")
                {
                    priceFlowers = countFlowers * 3;
                    if (countFlowers < 120)
                    {
                        priceFlowers = priceFlowers + (priceFlowers * 0.15);
                    }
                }
                else
                {
                    priceFlowers = countFlowers * 2.50;
                    if (countFlowers < 80)
                    {
                        priceFlowers += priceFlowers * 0.20;
                    }
                }
            }
            if (budget >= priceFlowers)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flowers} and {budget - priceFlowers:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {priceFlowers - budget:f2} leva more.");
            }
        }
    }
}
