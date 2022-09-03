using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
            {
                for (int secondD = 1; secondD <= 9; secondD++)
                {
                    for (int thirdD = 1; thirdD <= 9; thirdD++)
                    {
                        for (int fourthD = 1; fourthD <= 9; fourthD++)
                        {
                            bool isSpecialNum = n % firstDigit == 0 && n % secondD == 0 && n % thirdD == 0 && n % fourthD == 0;

                            if (isSpecialNum)
                            {
                                Console.Write($"{firstDigit}{secondD}{thirdD}{fourthD} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
