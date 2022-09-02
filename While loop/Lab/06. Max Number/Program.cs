using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
            int max = int.MinValue;

            while (input != "Stop")
            {
                int newNum = int.Parse(input);

                if (newNum>max)
                {
                    max = newNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
