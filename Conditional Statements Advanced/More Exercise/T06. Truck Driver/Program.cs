using System;

namespace T06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmForMonth = double.Parse(Console.ReadLine());

            double salary = 0;

            if (kmForMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = (kmForMonth * 0.75) * 4;
                }
                else if (season == "Summer")
                {
                    salary = (kmForMonth * 0.90) * 4;
                }
                else if (season == "Winter")
                {
                    salary = (kmForMonth * 1.05) * 4;
                }
            }
            else if (kmForMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = (kmForMonth * 0.95) * 4;
                }
                else if (season == "Summer")
                {
                    salary = (kmForMonth * 1.1) * 4;
                }
                else if (season == "Winter")
                {
                    salary = (kmForMonth * 1.25) * 4;
                }
            }
            else if (kmForMonth <= 20000)
            {
                salary = (kmForMonth * 1.45) * 4;
            }

            salary *= 0.90;

            Console.WriteLine($"{salary:f2}");
        }
    }
}
