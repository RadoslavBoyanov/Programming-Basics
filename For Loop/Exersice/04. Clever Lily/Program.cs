using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceForOneToy = int.Parse(Console.ReadLine());
        
            int toys = 0;
            double money = 0;
            
            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 == 0)
                {
                    money += (5 * i) - 1; 
                }
                else 
                {
                    toys++;
                }
            }

            double moneyFromToys = priceForOneToy * toys;

            money = money + moneyFromToys;

            if (money >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {money - priceOfWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceOfWashingMachine - money:f2}");
            }
        }
    }
}
