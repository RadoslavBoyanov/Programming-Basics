using System;

namespace T08._Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            string touch = string.Empty;

            if ((x == x1 || x == x2) && y >= y1 && y <= y2)
            {
                touch = "Border";
            }
            else if ((y == y1 || y == y2) && x >= x1 && x <= x2)
            {
                touch = "Border";
            }
            else
            {
                touch = "Inside / Outside";
            }

            Console.WriteLine($"{touch}");
        }
    }
}
