using System;

namespace T02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForRest = int.Parse(Console.ReadLine());

            int oneYear = 365;
            int workingDays = oneYear - daysForRest;
            int playingTimeInWorkingDays = workingDays * 63;
            int playingTimeInRestDays = daysForRest * 127;
            int timeForPlay = playingTimeInRestDays + playingTimeInWorkingDays;


            if (timeForPlay <= 30000)
            {
                double lessHours = 30000 - timeForPlay;
                double h = lessHours / 60;
                double m = lessHours % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(h)} hours and {m:f0} minutes less for play");
            }
            else
            {
                double moreHours = timeForPlay - 30000;
                double h = Math.Abs(moreHours / 60);
                double m = moreHours % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(h)} hours and {m:f0} minutes more for play");
            }
        }
    }
}
