using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int min = int.MaxValue;

            while (input != "Stop")
            {
                int someNum = int.Parse(input);

                if (someNum < min)
                {
                    min = someNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
