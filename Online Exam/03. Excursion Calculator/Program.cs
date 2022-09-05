using System;

namespace _03._Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalSum = 0;

            if (people <= 5)
            {
                switch (season)
                {
                    case "spring":
                        totalSum = 50 * people;
                        break;
                    case "summer":
                        totalSum = 48.50 * people;
                        break;
                    case "autumn":
                        totalSum = 60 * people;
                        break;
                    case "winter":
                        totalSum = 86 * people;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (season)
                {
                    case "spring":
                        totalSum = 48 * people;
                        break;
                    case "summer":
                        totalSum = 45 * people;
                        break;
                    case "autumn":
                        totalSum = 49.50 * people;
                        break;
                    case "winter":
                        totalSum = 85 * people;
                        break;
                    default:
                        break;
                }
            }

            if (season == "summer")
            {
                totalSum *= 0.85;
            }
            else if (season == "winter")
            {
                totalSum = totalSum + (totalSum * 0.08);
            }

            Console.WriteLine($"{totalSum:f2} leva.");
        }
    }
}
