using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            double termOfDeposit = double.Parse(Console.ReadLine());
            double anualPerc = double.Parse(Console.ReadLine());

            double increase = depositSum * (anualPerc / 100);
            double increasePerMonth = increase / 12;
            double totalSum = depositSum + termOfDeposit * increasePerMonth;

            Console.WriteLine(totalSum);
        }
    }
}
