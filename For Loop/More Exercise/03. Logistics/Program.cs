using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCargo = int.Parse(Console.ReadLine());
            double minibus = 0;
            double truck = 0;
            double train = 0;

            double tonesMinibus = 0;
            double tonesTruck = 0;
            double tonesTrain = 0;

            for (int i = 1; i <= countOfCargo; i++)
            {
                int tonesFromCargo = int.Parse(Console.ReadLine());

                if (tonesFromCargo <=3)
                {
                    tonesMinibus += tonesFromCargo;
                    minibus++;
                }
                else if (tonesFromCargo <= 11)
                {
                    tonesTruck += tonesFromCargo;
                    truck++;
                }
                else
                {
                    tonesTrain += tonesFromCargo;
                    train++;
                }
            }
            double totalTones = tonesMinibus + tonesTruck + tonesTrain;
            double averagePrice = (tonesMinibus * 200 + tonesTruck * 175 + tonesTrain * 120) / totalTones;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{tonesMinibus/totalTones * 100:f2}%");
            Console.WriteLine($"{tonesTruck/totalTones * 100:F2}%");
            Console.WriteLine($"{tonesTrain/totalTones * 100:F2}%");
        }
    }
}
