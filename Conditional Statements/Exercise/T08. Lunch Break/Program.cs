using System;

namespace T08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTv = Console.ReadLine();
            int timeOfEpizod = int.Parse(Console.ReadLine());
            int timeBreak = int.Parse(Console.ReadLine());

            double timeForLaunch = timeBreak * 0.125;
            double timeForRest = timeBreak * 0.25;
            double freeTime = timeBreak - timeForLaunch - timeForRest;

            if (freeTime >= timeOfEpizod)
            {
                Console.WriteLine($"You have enough time to watch {nameOfTv} and left with {Math.Ceiling(freeTime - timeOfEpizod)} minutes free time.");
            }
            else
            {
                double neededTime = timeOfEpizod - freeTime;
                Console.WriteLine($"You don't have enough time to watch {nameOfTv}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
