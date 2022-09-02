using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricity = 0;
            double water = 0;
            double internet = 0;
            double other = 0;

            for (int i = 1; i <= months; i++)
            {
                double priceForElectricity = double.Parse(Console.ReadLine());

                if (i <= months)
                {
                    electricity += priceForElectricity;
                    water += 20;
                    internet += 15;
                    other += (priceForElectricity + 20 + 15) + ((priceForElectricity + 20 + 15) * 0.20);
                }
            }
            double priceForEvrytingh = electricity + water + internet + other;
            double average = priceForEvrytingh / months;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {other:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
