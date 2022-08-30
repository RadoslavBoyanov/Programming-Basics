using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfFoodForDog = int.Parse(Console.ReadLine());
            int countOfFoodForCat = int.Parse(Console.ReadLine());

            double pricePerDogFood = 2.5;
            double pricePerCatFood = 4;
            double sum = countOfFoodForDog * pricePerDogFood + countOfFoodForCat *
                pricePerCatFood;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
