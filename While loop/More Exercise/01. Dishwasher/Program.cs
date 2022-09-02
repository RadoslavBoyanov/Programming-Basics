using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottleOfDetergeant = int.Parse(Console.ReadLine());
            int dishesClean = 0;
            int potsClean = 0;
            double mlDetergeant = bottleOfDetergeant * 750;
            int readBottles = 0;
            string countVessels;
            while ((countVessels = Console.ReadLine()) != "End")
            {
                int bottles = int.Parse(countVessels);

                readBottles++;
                if (readBottles % 3 == 0)
                {
                    potsClean += bottles;
                    mlDetergeant -= bottles * 15;
                }
                else
                {
                    dishesClean += bottles;
                    mlDetergeant -= bottles * 5;
                }
                if (mlDetergeant < 0)
                {
                    break;
                }
            }
            if (mlDetergeant >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesClean} dishes and {potsClean} pots were washed.");
                Console.WriteLine($"Leftover detergent {mlDetergeant} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(mlDetergeant)} ml. more necessary!");
            }
        }
    }
}
