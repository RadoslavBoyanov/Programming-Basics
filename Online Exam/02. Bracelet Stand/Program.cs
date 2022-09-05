using System;

namespace _02._Bracelet_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForOneDay = double.Parse(Console.ReadLine());
            double moneyWon = double.Parse(Console.ReadLine());
            double spendMoney = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double saveMoney = moneyForOneDay * 5;
            double totalMoneyFromSells = moneyWon * 5;
            double totalMoney = saveMoney + totalMoneyFromSells;
            totalMoney -= spendMoney;

            if (totalMoney >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice - totalMoney:f2} BGN.");
            }
        }
    }
}
