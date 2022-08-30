using System;

namespace Т07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double finalResult = side1 * side2;
                Console.WriteLine($"{finalResult:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double finalResult = r * r * Math.PI;
                Console.WriteLine($"{finalResult:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double sum = a * h / 2;
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
