using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int wildth = int.Parse(Console.ReadLine());
            string input;
            int countPieces = lenght * wildth;

            while ((input = Console.ReadLine()) != "STOP")
            {
                int newTake = int.Parse(input);
                countPieces -= newTake;
                if (countPieces <= 0)
                {
                    break;
                }
            }

            if (countPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(countPieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{countPieces} pieces are left.");
            }
        }
    }
}
