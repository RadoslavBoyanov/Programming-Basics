using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int threedigits = int.Parse(Console.ReadLine());
            int lastNumber = threedigits % 10;
            int secNumber = threedigits % 100;
            secNumber /= 10;
            int firstNum = threedigits / 100;
            double sum = 1;

            for (int three = 1; three <= lastNumber; three++)
            {
                for (int two = 1; two <= secNumber; two++)
                {
                    for (int one = 1; one <= firstNum; one++)
                    {
                        sum = one * two * three;
                        Console.WriteLine($"{three} * {two} * {one} = {sum};");
                    }
                }
            }
        }
    }
}
