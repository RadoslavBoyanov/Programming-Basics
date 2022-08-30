using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());

            int timeForReading = pagesCount / pagesPerHour;
            int hoursPerDay = timeForReading / daysCount;

            Console.WriteLine(hoursPerDay);
        }
    }
}
