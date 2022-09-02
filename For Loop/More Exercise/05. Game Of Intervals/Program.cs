using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMoves = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double invalid = 0;
            double points = 0;

            for (int i = 1; i <= countMoves; i++)
            {
                int move = int.Parse(Console.ReadLine());

                if (move >= 0 && move <= 9)
                {
                    p1++;
                    points += move * 0.2;
                }
                else if (move>= 10 && move <= 19)
                {
                    p2++;
                    points += move * 0.3;
                }
                else if (move >=20 && move <= 29)
                {
                    p3++;
                    points += move * 0.4;
                }
                else if (move >= 30 && move <= 39)
                {
                    p4++;
                    points += 50;
                }
                else if (move>= 40 && move <= 50)
                {
                    p5++;
                    points += 100;
                }
                else if (move < 0 || move > 50)
                {
                    points = points / 2;
                    invalid++;
                }
            }

            double per1 = p1 / countMoves * 100;
            double per2 = p2 / countMoves * 100;
            double per3 = p3 / countMoves * 100;
            double per4 = p4 / countMoves * 100;
            double per5 = p5 / countMoves * 100;
            double per6 = invalid / countMoves * 100;

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {per1:f2}%");
            Console.WriteLine($"From 10 to 19: {per2:f2}%");
            Console.WriteLine($"From 20 to 29: {per3:f2}%");
            Console.WriteLine($"From 30 to 39: {per4:f2}%");
            Console.WriteLine($"From 40 to 50: {per5:f2}%");
            Console.WriteLine($"Invalid numbers: {per6:f2}%");
        }
    }
}
