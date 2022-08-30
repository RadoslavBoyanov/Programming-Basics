using System;

namespace T03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMetresVineyard = int.Parse(Console.ReadLine());
            double gravesForOneSquareMeter = double.Parse(Console.ReadLine());
            int wineLitresNeeded = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double gravesFromVineyard = squareMetresVineyard * gravesForOneSquareMeter;
            double wineLiters = gravesFromVineyard * 0.40 / 2.5;

            if (wineLiters < wineLitresNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLitresNeeded - wineLiters)} liters wine needed.");
            }
            else 
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLiters - wineLitresNeeded)} liters left -> {Math.Ceiling(wineLiters - wineLitresNeeded)/workersCount} liters per person.");
            }

        }
    }
}
