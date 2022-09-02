using System;

namespace _11._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double minEven = 1000000000000.00;
            double maxEven = -1000000000000.00;
            double minOdd = 1000000000000.00;
            double maxOdd = -1000000000000.00;
            double even = 0;
            double odd = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    even += num;
                    if (num > maxEven)
                    {
                        maxEven = num;
                    }
                    else
                    {
                        minEven = num;
                    }
                }
                else
                {
                    odd += num;
                    even += num;
                    if (num > maxOdd)
                    {
                        maxOdd = num;
                    }
                    else
                    {
                        minOdd = num;
                    }
                }
            }
        }
    }
}
