using System;

namespace T06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double timeForSwimming = distanceInMetres * timeInSecondsForOneMeter;
            double waterResistanceDistance = Math.Floor(distanceInMetres / 15);
            double waterResistanceInSeconds = waterResistanceDistance * 12.5;
            double totalTimeForSwimming = timeForSwimming + waterResistanceInSeconds;

            if (recordInSeconds <= totalTimeForSwimming)
            {
                Console.WriteLine($"No, he failed! He was {totalTimeForSwimming - recordInSeconds:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeForSwimming:f2} seconds.");
            }
        }
    }
}
