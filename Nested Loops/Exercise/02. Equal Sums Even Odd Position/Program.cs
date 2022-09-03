using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int num = start; num <= end; num++)
            {
                //string currentNum = num.ToString();
                int evenSum = 0;
                int oddSum = 0;
                string currentNum = num.ToString();
                
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());

                    if (j % 2 ==0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
