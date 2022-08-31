using System;

namespace T06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char a = char.Parse(Console.ReadLine());

            double result = 0;
            string evenOrOdd = "";

            if ( a == '+' || a == '-' || a == '*')
            {
                if (a == '+')
                {
                    result = num1 + num2;
                }
                else if (a == '-')
                {
                    result = num1 - num2;
                }
                else
                {
                    result = num1 * num2;
                }

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {a} {num2} = {result} - {evenOrOdd}");
            }
            
            if (a == '/' && num2 != 0)
            {
                result = (double)num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result:f2}");
            }
            
            if (a == '%' && num2 != 0)
            {
                result = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {result}");
            }

            if ((a == '/' || a == '%') && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
        }
    }
}
