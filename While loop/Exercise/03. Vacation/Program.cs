using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double journyMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int passedDays = 0;
            int daySpendedMoney = 0;

            while (money < journyMoney)
            {
                string spendOrSave = Console.ReadLine();
                double spendMoney = double.Parse(Console.ReadLine());
                passedDays++;

                if (spendOrSave == "spend")
                {
                    money -= spendMoney;
                    if (money < 0)
                    {
                        money = 0;
                    }
                    daySpendedMoney++;
                    if (daySpendedMoney >=5 )
                    {
                        break;
                    }
                }
                else if (spendOrSave == "save")
                {
                    money += spendMoney;
                    daySpendedMoney = 0;
                }
            }
            if (daySpendedMoney >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(passedDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {passedDays} days.");
            }
        }
    }
}
