using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capOfStadium = int.Parse(Console.ReadLine());
            int countOfFans = int.Parse(Console.ReadLine());

            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;

            for (int i = 1; i <= countOfFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    a++;
                }
                else if (sector == "B")
                {
                    b++;
                }
                else if (sector == "V")
                {
                    v++;
                }
                else if (sector == "G")
                {
                    g++;
                }
            }

            double perA = a / countOfFans * 100;
            double perB = b / countOfFans * 100;
            double perV = v / countOfFans * 100;
            double perG = g / countOfFans * 100;

            double perFans = (double)countOfFans / capOfStadium * 100;

            Console.WriteLine($"{perA:f2}%");
            Console.WriteLine($"{perB:f2}%");
            Console.WriteLine($"{perV:f2}%");
            Console.WriteLine($"{perG:f2}%");
            Console.WriteLine($"{perFans:f2}%");
        }
    }
}
