using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int countЕxcursionsSea = int.Parse(Console.ReadLine());
            int countЕxcursionsMountain = int.Parse(Console.ReadLine());
            double totalSum = 0;

            string seaOrMountain;
            while ((seaOrMountain = Console.ReadLine()) != "Stop")
            {
                if (seaOrMountain == "sea" && countЕxcursionsSea > 0)
                {
                    totalSum += 680;
                    countЕxcursionsSea--;
                }
                if (seaOrMountain == "mountain" && countЕxcursionsMountain > 0)
                {
                    totalSum += 499;
                    countЕxcursionsMountain--;
                }
                if (countЕxcursionsMountain < 1 && countЕxcursionsSea < 1)
                {
                    break;
                }
            }

            if (countЕxcursionsMountain < 1 && countЕxcursionsSea < 1)
            {
                Console.WriteLine("Good job! Everything is sold.");
                Console.WriteLine($"Profit: {totalSum} leva.");
            }
            else
            {
                Console.WriteLine($"Profit: {totalSum} leva.");
            }
        }
    }
}
