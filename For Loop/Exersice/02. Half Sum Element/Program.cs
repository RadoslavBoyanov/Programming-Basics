using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxValue = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
                if (currNum > maxValue)
                {
                    maxValue = currNum;
                }
            }
            int sumWithoutMaxNumber = sum - maxValue;

            if (maxValue == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNumber}");
            }
            else
            {
                int diff = Math.Abs(maxValue - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
