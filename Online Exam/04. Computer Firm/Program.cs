using System;

namespace _04._Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int countComps = int.Parse(Console.ReadLine());
            double sells = 0;
            double avrRating = 0;
            double rating = 0;
            double percent = 0;
            double madeSells = 0;

            for (int i = 1; i <= countComps; i++)
            {
                double sellsAndRating = double.Parse(Console.ReadLine());
                rating = sellsAndRating % 10;
                avrRating += sellsAndRating % 10;
                sells = Math.Floor(sellsAndRating / 10);
                switch (rating)
                {
                    case 2:
                        madeSells += 0;
                        break;
                    case 3:
                        madeSells += sells * 0.50;
                        break;
                    case 4:
                        madeSells += sells * 0.70;
                        break;
                    case 5:
                        madeSells += sells * 0.85;
                        break;
                    case 6:
                        madeSells += sells;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{madeSells:f2}");
            Console.WriteLine($"{avrRating / countComps:f2}");

        }
    }
}
