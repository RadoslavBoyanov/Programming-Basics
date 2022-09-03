using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    int rezult = a * b;
                    Console.WriteLine($"{a} * {b} = {rezult}");
                }
            }
        }
    }
}
