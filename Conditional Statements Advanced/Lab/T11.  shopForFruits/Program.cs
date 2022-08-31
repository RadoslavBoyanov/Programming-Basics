using System;

namespace T11.__shopForFruits
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalSum = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    totalSum = quantity * 2.50;
                }
                else if (fruit == "apple")
                {
                    totalSum = quantity * 1.20;
                }
                else if (fruit == "orange")
                {
                    totalSum = quantity * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    totalSum = quantity * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    totalSum = quantity * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    totalSum = quantity * 5.50;
                }
                else if (fruit == "grapes")
                {
                    totalSum = quantity * 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    totalSum = quantity * 2.70;
                }
                else if (fruit == "apple")
                {
                    totalSum = quantity * 1.25;
                }
                else if (fruit == "orange")
                {
                    totalSum = quantity * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    totalSum = quantity * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    totalSum = quantity * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    totalSum = quantity * 5.60;
                }
                else if (fruit == "grapes")
                {
                    totalSum = quantity * 4.20;
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
