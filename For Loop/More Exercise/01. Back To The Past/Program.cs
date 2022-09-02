using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int ivanchoYears = 17;
            double costs = 0;

            for (int i = 1800; i <= year; i++)
            {
                ivanchoYears++;
                if (i % 2 == 0)
                {
                    costs += 12000;
                }
                else
                {
                    costs += 12000 + 50 * ivanchoYears;
                }
            }

            if (costs <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money - costs:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {costs - money:F2} dollars to survive.");
            }
        }
    }
}
