using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());

            double priceOfOneSquareMeter = 7.61;
            double totalPrice = squareMeters * priceOfOneSquareMeter;
            double discount = 0.18 * totalPrice; 
            double finalPrice = totalPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
