using System;

namespace T12__tradeCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double totalSum = 0;

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    totalSum = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    totalSum = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    totalSum = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    totalSum = sales * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    totalSum = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    totalSum = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    totalSum = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    totalSum = sales * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    totalSum = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    totalSum = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    totalSum = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    totalSum = sales * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (totalSum > 0)
            {
                Console.WriteLine($"{totalSum:f2}");
            }
           
        }
    }
}
