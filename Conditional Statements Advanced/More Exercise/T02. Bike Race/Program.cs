using System;

namespace T02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsCyclers = int.Parse(Console.ReadLine());
            int seniorsCyclers = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double tax = 0;

            switch (trace)
            {
                case "trail":
                    tax = (juniorsCyclers * 5.50) + (seniorsCyclers * 7);
                    break;
                case "cross-country":
                    tax = (juniorsCyclers * 8) + (seniorsCyclers * 9.50);
                    if (juniorsCyclers + seniorsCyclers >= 50)
                    {
                        tax *= 0.75;
                    }
                    break;
                case "downhill":
                    tax = (juniorsCyclers * 12.25) + (seniorsCyclers * 13.75);
                    break;
                case "road":
                    tax = (juniorsCyclers * 20) + (seniorsCyclers * 21.50);
                    break;
                default:
                    break;
            }

            tax -= tax * 0.05;

            Console.WriteLine($"{tax:f2}");
        }
    }
}
