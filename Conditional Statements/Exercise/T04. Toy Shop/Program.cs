using System;

namespace T04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzleQantity = int.Parse(Console.ReadLine());
            int dollsQantity = int.Parse(Console.ReadLine());
            int bearsQantity = int.Parse(Console.ReadLine());
            int minionsQantity = int.Parse(Console.ReadLine());
            int trucksQantity = int.Parse(Console.ReadLine());

            int toysQuantity = puzzleQantity + dollsQantity + bearsQantity
                + minionsQantity + trucksQantity;

            double totalPrice = puzzleQantity * 2.6 +
                dollsQantity * 3 +
                bearsQantity * 4.10 +
                minionsQantity * 8.2 +
                trucksQantity * 2;

            if (toysQuantity >= 50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            totalPrice = totalPrice - totalPrice * 0.10;

            if (totalPrice >= tripPrice)
            {
                Console.WriteLine($"Yes! {(totalPrice - tripPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalPrice:F2} lv needed.");
            }
        }
    }
}