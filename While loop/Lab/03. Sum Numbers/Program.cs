using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int total = 0;

            while (total < number)
            {
                int newNumber = int.Parse(Console.ReadLine());
                total += newNumber;
            }

            Console.WriteLine(total);
        }
    }
}
