using System;

namespace T04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());

            double rentBoat = 0;

            switch (season)
            {
                case "Spring":
                    rentBoat = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rentBoat = 4200;
                    break;
                case "Winter":
                    rentBoat = 2600;
                    break;
                default:
                    break;
            }
            if (countFishers <= 6)
            {
                rentBoat = rentBoat - (rentBoat * 0.10);
            }
            else if (countFishers <= 11 )
            {
                rentBoat = rentBoat - rentBoat * 0.15;
            }
            else
            {
                rentBoat *= 0.75;
            }
            if (countFishers % 2 == 0 && season != "Autumn")
            {
                rentBoat -= rentBoat * 0.05;
            }
            if (budget >= rentBoat)
            {
                Console.WriteLine($"Yes! You have {budget - rentBoat:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rentBoat - budget:f2} leva.");
            }
        }
    }
}
