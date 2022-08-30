using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double rearWall = x * x;
            double frontWall = x * x - (1.2 * 2);
            double frontRearWalls = rearWall + frontWall;

            double asideWall = x * y - (1.5 * 1.5);
            double bsideWall = x * y - (1.5 * 1.5);
            double sideWalls = asideWall + bsideWall;

            double areaWalls = frontRearWalls + sideWalls;
            double greenPaintForLiterExpense = 3.4;
            double greenPaintLitres = areaWalls / greenPaintForLiterExpense;

            double roofRectangles = 2 * (x * y);
            double roofTriangles = 2 * (x * h / 2);
            double roofArea = roofRectangles + roofTriangles;
            double redPaintForLiterExpense = 4.3;
            double redPaintLitres = roofArea / redPaintForLiterExpense;

            Console.WriteLine($"{greenPaintLitres:F2}");
            Console.WriteLine($"{redPaintLitres:F2}");
        }
    }
}
