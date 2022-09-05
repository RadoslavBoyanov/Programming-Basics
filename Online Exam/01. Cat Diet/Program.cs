using System;

namespace _01._Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            int percentsFats = int.Parse(Console.ReadLine());
            int percentsProteins = int.Parse(Console.ReadLine());
            int percentsCarbo = int.Parse(Console.ReadLine());
            int totalcall = int.Parse(Console.ReadLine());
            int waterPer = int.Parse(Console.ReadLine());

            double gramsFats = ((double)percentsFats * totalcall/100) / 9;
            double gramsProteins = ((double)percentsProteins * totalcall / 100) / 4;
            double gramsCarbo = ((double)percentsCarbo * totalcall / 100) / 4;

            double totalGrams = gramsFats + gramsCarbo + gramsProteins;
            double calories = totalcall / totalGrams;

            double sum = calories - (calories * waterPer/100);
            Console.WriteLine($"{sum:f4}");
        }
    }
}
