using System;

namespace T01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double places = (double)rows * columns;
            double income = 0;

            if (projection == "Premiere")
            {
                income = places * 12;
            }
            else if (projection == "Normal")
            {
                income = places * 7.50;
            }
            else
            {
                income = places * 5;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
