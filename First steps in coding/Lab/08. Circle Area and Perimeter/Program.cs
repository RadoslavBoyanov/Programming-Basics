using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = r * r * Math.PI;
            double parameter = 2 * Math.PI * r;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{parameter:F2}");
        }
    }
}
