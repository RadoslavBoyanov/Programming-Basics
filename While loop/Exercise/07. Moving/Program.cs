using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int wildth = int.Parse(Console.ReadLine());
            int longht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double spaceOfBox = 0;
            double freeSpace = wildth * longht * height;

            string box;
            while ((box = Console.ReadLine()) != "Done")
            {
                int numBox = int.Parse(box);

                spaceOfBox += numBox;
                if (spaceOfBox > freeSpace)
                {
                    break;
                }
            }

            if (spaceOfBox > freeSpace)
            {
                Console.WriteLine($"No more free space! You need {spaceOfBox - freeSpace} Cubic meters more.");
            }
            else
            {
                if (freeSpace > spaceOfBox)
                {
                    Console.WriteLine($"{freeSpace - spaceOfBox} Cubic meters left.");
                }
            }
        }
    }
}
