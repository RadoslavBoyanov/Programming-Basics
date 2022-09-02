using System;

namespace _09._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 00; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hours} : {minutes}");
                }
            }
        }
    }
}
