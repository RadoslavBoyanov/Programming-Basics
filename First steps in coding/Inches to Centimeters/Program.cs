using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double inches = 2.54;
            double centimeters = number * inches;
            Console.WriteLine(centimeters);
        }
    }
}
