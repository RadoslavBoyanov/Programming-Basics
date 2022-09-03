using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            for (int num1 = 2; num1 <= firstNum; num1 += 2)
            {

                for (int num2 = 2; num2 <= secondNum; num2++)
                {
                    if (num2 == 2||num2 == 3|| num2 == 5|| num2 == 7)
                    {
                        for (int num3 = 2; num3 <= thirdNum; num3 += 2)
                        {
                            Console.WriteLine($"{num1} {num2} {num3}");
                        }
                    }

                }
                
            }
            
        }
    }
}
