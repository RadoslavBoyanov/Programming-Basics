using System;

namespace T04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string clas = "";
            string typeCars = "";
            double price = 0;

            if (budget <= 100)
            {
                clas = "Economy class";

                switch (season)
                {
                    case "Winter":
                        typeCars = "Jeep";
                        price = budget * 0.65;
                            break;
                    case "Summer":
                        typeCars = "Cabrio";
                        price = budget * 0.35;
                        break;
                    default:
                        break;
                }
            }
            else if (budget <= 500)
            {
                clas = "Compact class";

                if (season == "Summer")
                {
                    typeCars = "Cabrio";
                    price = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    typeCars = "Jeep"; price = budget * 0.80;
                }
            }
            else 
            {
                clas = "Luxury class";
                typeCars = "Jeep";
                price = budget * 0.90;
            }

            Console.WriteLine($"{clas}");
            Console.WriteLine($"{typeCars} - {price:f2}");
        }
    }
}
