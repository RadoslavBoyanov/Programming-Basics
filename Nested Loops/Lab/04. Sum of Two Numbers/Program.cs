using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isReach = false;

            for (int num1 = firstNum; num1 <= endNum; num1++)
            {
                for (int num2 = firstNum; num2 <= endNum; num2++)
                {
                    combinations++;
                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({num1} + {num2} = {magicNum})");
                        isReach = true;
                        break;
                    }
                }
                if (isReach == true)
                {
                    break;
                }
            }
            if (!isReach)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
            
        }
    }
}
