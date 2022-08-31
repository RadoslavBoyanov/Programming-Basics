using System;

namespace T05._shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalSum = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    totalSum = quantity * 0.50;
                }
                else if (product == "water")
                {
                    totalSum = quantity * 0.80;
                }
                else if (product == "beer")
                {
                    totalSum = quantity * 1.20;
                }
                else if (product == "sweets")
                {
                    totalSum = quantity * 1.45;
                }
                else if (product == "peanuts")
                {
                    totalSum = quantity * 1.60;
                }
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    totalSum = quantity * 0.40;
                }
                else if (product == "water")
                {
                    totalSum = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    totalSum = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    totalSum = quantity * 1.30;
                }
                else if (product == "peanuts")
                {
                    totalSum = quantity * 1.50;
                }
            }
            if (town == "Varna")
            {
                if (product == "coffee")
                {
                    totalSum = quantity * 0.45;
                }
                else if (product == "water")
                {
                    totalSum = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    totalSum = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    totalSum = quantity * 1.35;
                }
                else if (product == "peanuts")
                {
                    totalSum = quantity * 1.55;
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
