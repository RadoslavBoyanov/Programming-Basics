using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;
            string num;
            while ((num = Console.ReadLine()) != "stop")
            {
                int currentNum = int.Parse(num);
                
               
                
                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                if (currentNum == 0)
                {
                    continue;
                }
                bool isPrimeNum = true;
                for (int i = 2; i < currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        isPrimeNum = false;
                        break;
                    }
                }
                if (isPrimeNum)
                {
                    primeSum += currentNum;
                }
                else
                {
                    nonPrimeSum += currentNum;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
