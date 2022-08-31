using System;

namespace T05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string typeOfRest = "";
            double price = 0;

            if (budget <= 1000)
            {
                typeOfRest = "Camp";

                if (season == "Summer")
                {
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                typeOfRest = "Hut";
                if (season == "Summer")
                {
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                { 
                    price = budget * 0.60;
                }
            }
            else
            {
                typeOfRest = "Hotel";
                price = budget * 0.90;
            }
            if (season == "Summer")
            {
                location = "Alaska";
            }
            else
            {
                location = "Morocco";
            }

            Console.WriteLine($"{location} - {typeOfRest} - {price:f2}");
        }
    }
}
