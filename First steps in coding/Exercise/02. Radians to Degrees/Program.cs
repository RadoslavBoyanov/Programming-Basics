using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double angleRadians = double.Parse(Console.ReadLine());

            double degrees = angleRadians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
