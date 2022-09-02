using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0.0;

            while (input != "NoMoreMoney")
            {
                double newNumber = double.Parse(input);
                if (newNumber < 0)
                {
                    Console.WriteLine("In" +
                        "" +
                        "valid operation!");
                    break;
                }
                total += newNumber;
                Console.WriteLine($"Increase: {newNumber:f2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
