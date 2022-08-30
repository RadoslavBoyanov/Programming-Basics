using System;

namespace T03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
